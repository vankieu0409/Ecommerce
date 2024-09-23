

namespace Ecommerce.Client.Services.Authentications;

public interface IAuthenticationService
{
    //public Task<UserDto> LoginService(LoginUserViewModel viewModel);
    //public Task<bool> RegiterService(CreateUserViewModel viewModel);
    //public Task<bool> Update(UpdateProfileVM vm);
    //public Task<List<RoleEntity>> GetRoleCollection();
    //public Task<HttpResponseMessage> RefreshToken();
    public Task<bool> IsUserAuthenticated();
    public Task<bool> LogoutService();
}