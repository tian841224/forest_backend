using admin_backend.DTOs.Login;
using admin_backend.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace admin_backend.Controllers
{
    /// <summary>
    /// �n�J
    /// </summary>
    [ApiController]
    [Route("[controller]/[action]")]

    public class LoginController : ControllerBase
    {
        private readonly ILoginServices _loginServices;

        public LoginController(ILoginServices loginServices)
        {
            _loginServices = loginServices;
        }

        /// <summary>
        /// �n�J
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginDto dto)
        {
            return Ok(await _loginServices.Login(dto));
        }

        /// <summary>
        /// �ѰO�K�X
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPost]
        [Authorize]
        public IActionResult ResetPassword(ResetPasswordDto dto)
        {
            _loginServices.ResetPassword(dto);
            return Ok();
        }
    }
}