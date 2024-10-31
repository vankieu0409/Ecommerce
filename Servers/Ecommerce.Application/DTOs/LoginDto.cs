using Ecommerce.Domain.Enum;

namespace Ecommerce.Application.DTOs;

public class LoginDto
{
    public string UserName { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
}
public class RegisterDto
{
    public string FullName { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
}

public class UserDto
{
    public Guid Id { get; set; }
    public string UserName { get; set; }
    public string DisplayName { get; set; }
    public string Decriptions { get; set; }
    public Role Role { get; set; }
    public string Image { get; set; }
    public bool Success { get; set; } = false;
    public string Message { get; set; } = string.Empty;
    public string AccessToken { get; set; } = string.Empty;
    public string RefreshToken { get; set; } = string.Empty;
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
    public DateTime RefreshTokenExpireTime { get; set; }


}


