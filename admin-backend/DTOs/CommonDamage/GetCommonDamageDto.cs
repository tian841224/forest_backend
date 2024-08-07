﻿using admin_backend.Enums;
using CommonLibrary.DTOs;

namespace admin_backend.DTOs.CommonDamage
{
    public class GetCommonDamageDto
    {
        /// <summary>
        /// 關鍵字
        /// </summary>
        public string? Keyword { get; set; } = string.Empty;

        ///// <summary>
        ///// 危害類型ID
        ///// </summary>
        //public int? DamageTypeId { get; set; }

        ///// <summary>
        ///// 危害種類ID
        ///// </summary>
        //public int? DamageClassId { get; set; }

        ///// <summary>
        ///// 病蟲危害名稱
        ///// </summary>
        //public string? Name { get; set; } = string.Empty;

        ///// <summary>
        ///// 危害部位
        ///// </summary>
        //public TreePartEnum? DamagePart { get; set; } = TreePartEnum.None;

        ///// <summary>
        ///// 危害特徵
        ///// </summary>
        //public string? DamageFeatures { get; set; } = string.Empty;

        ///// <summary>
        ///// 防治建議
        ///// </summary>
        //public string? Suggestions { get; set; } = string.Empty;

        ///// <summary>
        ///// 病蟲封面照片
        ///// </summary>
        //public string? Photo { get; set; } = string.Empty;

        /// <summary>
        /// 狀態 0 = 關閉, 1 = 開啟
        /// </summary>
        public StatusEnum? Status { get; set; } = StatusEnum.Open;

        /// <summary>
        /// 分頁參數
        /// </summary>
        public PagedOperationDto? Page { get; set; } = new PagedOperationDto();
    }
}
