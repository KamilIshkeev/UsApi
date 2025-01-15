using Microsoft.AspNetCore.Mvc;
using UserApi.Requests;

namespace UserApi.Interfaces
{
    public interface IUsersLoginsService
    {
        Task<IActionResult> GetAllUsersAsync();
        Task<IActionResult> CreateNewUserAndLoginAsync(CreateNewUserAndLogin newUser);
    }
}
