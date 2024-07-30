﻿using admin_backend.Services;
using CommonLibrary.DTOs.TreeBasicInfo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace admin_backend.Controllers
{
    /// <summary>
    /// 樹木基本資料
    /// </summary>
    [ApiController]
    [Route("[controller]/[action]")]
    public class TreeBasicInfoController : ControllerBase
    {
        private readonly TreeBasicInfoService _treeBasicInfoService;

        public TreeBasicInfoController(TreeBasicInfoService treeBasicInfoService)
        {
            _treeBasicInfoService = treeBasicInfoService;
        }

        /// <summary>
        /// 取得樹木基本資料
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Get()
        {
            return Ok(await _treeBasicInfoService.Get());
        }

        /// <summary>
        /// 新增樹木基本資料
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Add(AddTreeBasicInfoDto dto)
        {
            return Ok(await _treeBasicInfoService.Add(dto));
        }

        /// <summary>
        /// 更新樹木基本資料
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPut]
        [Authorize]
        public async Task<IActionResult> Update(UpdateTreeBasicInfoDto dto)
        {
            return Ok(await _treeBasicInfoService.Update(dto));
        }

        /// <summary>
        /// 刪除樹木基本資料
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpDelete]
        [Authorize]
        public async Task<IActionResult> Delete(DeleteTreeBasicInfoDto dto)
        {
            return Ok(await _treeBasicInfoService.Delete(dto));
        }
    }
}
