using admin_backend.Services;
using CommonLibrary.DTOs.Login;
using Microsoft.AspNetCore.Mvc;

namespace admin_backend.Controllers
{
        [ApiController]
    [Route("[controller]/[action]")]
    /// <summary>
    /// �n�J
    /// </summary>
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
        //[Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetCaptcha()
        {
            return Ok(await _loginServices.GetCaptchaAsync());
        }


        /// <summary>
        /// �n�J
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        //[Authorize(Roles = "Admin")]
        public async Task<IActionResult> Login(LoginDto dto)
        {
            return Ok(await _loginServices.Login(dto));
        }
    }
}