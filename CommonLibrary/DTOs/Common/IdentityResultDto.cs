﻿namespace CommonLibrary.DTOs.Common
{
    public class IdentityResultDto
    {
        public string AccessToken { get; set; } = string.Empty;

        //public string RefreshToken { get; set; } = string.Empty;

        public long Expires { get; set; }

        public string Account { get; set; } = string.Empty;

        public int RoleId { get; set; }
    }
}
