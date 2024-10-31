using Ecommerce.Application.DTOs;

namespace Ecommerce.Application.Interfaces.IServices;

public interface IAuthenticationService
{
    public Task<UserDto> Login(LoginDto request);
    public Task<UserDto> RegisterUser(RegisterDto request);
    //public Task<bool> Update(UpdateProfileVM resquest);
    public Task<UserDto> RefreshToken();
    //public void SetRefreshToken(RefreshTokenDto refreshToken, UserEntity user);
    public bool Logout();



}