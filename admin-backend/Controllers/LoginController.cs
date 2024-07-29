using admin_backend.Services;
using CommonLibrary.DTOs.Login;
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
        private readonly LoginServices _loginServices;

        public LoginController(LoginServices loginServices)
        {
            _loginServices = loginServices;
        }

        /// <summary>
        /// ���o���ҽX
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> GetCaptcha()
        {
            return Ok(await _loginServices.GetCaptchaAsync());
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
        /// ��sToken
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> RefreshAdminUserToken(RefreshTokenDto dto)
        {
            return Ok(await _loginServices.RefreshAdminUserTokenAsync(dto));
        }
    }
}