﻿using System.ComponentModel.DataAnnotations;

namespace CommonLibrary.DTOs.TreeBasicInfo
{
    public class UpdateTreeBasicInfoDto
    {
        [Required]
        public int Id { get; set; }

        /// <summary>
        /// 學名
        /// </summary>
        public string? ScientificName { get; set; } = string.Empty;

        /// <summary>
        /// 名稱
        /// </summary>
        public string? Name { get; set; } = string.Empty;
    }
}
