using admin_backend.Services;
using CommonLibrary.DTOs.AdminUser;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace admin_backend.Controllers
{
    /// <summary>
    /// ��x�b��
    /// </summary>
    [ApiController]
    [Route("[controller]/[action]")]
    public class AdminUserController : ControllerBase
    {
        private readonly AdminUserServices _adminUserServices;

        public AdminUserController(AdminUserServices adminUserServices)
        {
            _adminUserServices = adminUserServices;
        }

        /// <summary>
        /// ���o��x�b��
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Get(GetAdminUserDto dto)
        {
            return Ok(await _adminUserServices.Get(dto));
        }

        /// <summary>
        /// ���o�ӤH���
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetPerson()
        {
            return Ok(await _adminUserServices.Get());
        }

        /// <summary>
        /// �s�W��x�b��
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Add(AddAdminUserDto dto)
        {
            return Ok(await _adminUserServices.Add(dto));
        }

        /// <summary>
        /// ��s��x�b��
        /// </summary>
        /// <param name="dto"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Update(int id, UpdateAdminUserDto dto)
        {
            return Ok(await _adminUserServices.Update(id, dto));
        }
    }
}
