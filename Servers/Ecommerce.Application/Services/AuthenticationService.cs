using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

using Ecommerce.Application.DTOs;
using Ecommerce.Application.Interfaces.IRepositories;
using Ecommerce.Application.Interfaces.IServices;
using Ecommerce.Domain.Enum;

using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace Ecommerce.Application.Services;

public class AuthenticationService : IAuthenticationService
{
    private readonly IRoleRepository _role;
    private readonly ICustomerRepository _customer;
    private readonly IEmployeeRepository _employee;
    //private readonly ApplicationDbContext _context;
    private readonly IConfiguration _configuration;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public AuthenticationService(IRoleRepository role, ICustomerRepository customer, IEmployeeRepository employee, IConfiguration configuration, IHttpContextAccessor httpContextAccessor)
    {
        _role = role ?? throw new ArgumentNullException(nameof(role));
        _customer = customer ?? throw new ArgumentNullException(nameof(customer));
        _employee = employee ?? throw new ArgumentNullException(nameof(employee));
        _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        _httpContextAccessor = httpContextAccessor ?? throw new ArgumentNullException(nameof(httpContextAccessor));
    }

    public async Task<UserDto> Login(LoginDto request)
    {
        var customer = await _customer.AsQueryable().FirstOrDefaultAsync(c => c.Email == request.UserName && VerifyPasswordHash(c.PasswordHash, request.Password));
        if (customer == null && customer!.Role.Name == Role.Customer.ToString())
        {
            return new UserDto()
            {
                AccessToken = CreateToken(customer.Id, customer.Email, customer.Role.Name),
                Id = customer.Id,
                UserName = customer.Email,
                DisplayName = customer.FullName,
                Role = Role.Customer,
                Success = true,
                Message = "Login successfully",
                Image = customer.Image ?? "",
            };
        }
        var employee = await _employee.AsQueryable().FirstOrDefaultAsync(e => e.Email == request.UserName && VerifyPasswordHash(e.PasswordHash, request.Password));
        if (employee != null && employee!.Role.Name != Role.Customer.ToString())
        {
            return new UserDto()
            {
                AccessToken = CreateToken(employee.Id, employee.Email, employee.Role.Name),
                Id = employee.Id,
                UserName = employee.Email,
                DisplayName = employee.FullName,
                Role = Role.Employee,
                Success = true,
                Message = "Login successfully",
                Image = employee.Avatar ?? "",
                Address = employee.ResidenceAddress
            };
        }
        return new UserDto()
        {
            Success = false,
            Message = "Login failed"
        };
    }

    public Task<UserDto> RegisterUser(RegisterDto request)
    {
        throw new NotImplementedException();
    }

    public Task<UserDto> RefreshToken()
    {
        throw new NotImplementedException();
    }

    private string CreateToken(Guid userId, string name, string role)
    {
        List<Claim> authClaims = new()
        {
            new(ClaimTypes.NameIdentifier, userId.ToString()),
            new(ClaimTypes.Name, name),
             new(ClaimTypes.Role, role)
        };

        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Authentication:Jwt:Secret"]));
        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        var token = new JwtSecurityToken(
            issuer: _configuration["Authentication:Jwt:ValidIssuer"],
            audience: _configuration["Authentication:Jwt:ValidAudience"],
            claims: authClaims,
            expires: DateTime.Now.AddHours(Convert.ToInt16(_configuration["Authentication:Jwt:ExpiresTime"])),
            signingCredentials: creds);
        var jwt = new JwtSecurityTokenHandler().WriteToken(token);
        return jwt;

    }

    public string CreateRefreshToken()
    {
        throw new NotImplementedException();
    }

    public bool Logout()
    {
        throw new NotImplementedException();
    }

    private string CreatePasswordSalt(string password)
    {
        var passwordBytes = Encoding.UTF8.GetBytes(password);
        var sha256 = SHA256.Create();
        var hashBytes = sha256.ComputeHash(passwordBytes);
        return Convert.ToBase64String(hashBytes);

    }

    public bool VerifyPasswordHash(string password, string passwordHash)
    {
        byte[] test;
        test = Convert.FromBase64String("passwordSalt");
        var hmac = new HMACSHA512(test);
        var computeHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
        return computeHash.SequenceEqual(Encoding.UTF8.GetBytes(passwordHash));
    }
}