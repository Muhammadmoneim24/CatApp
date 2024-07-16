using ChatApp.Dtos;

namespace ChatApp.Sevices
{
    public interface IAuthService
    {
        Task<AuthModel>RegisterAsync(RegisterModel model);
        Task<AuthModel> LoginAsync(LoginModel model);
        //Task<string> AddRoleAsync(AddRoleModel model);
    }
}
