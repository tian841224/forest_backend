﻿namespace CommonLibrary.DTOs.Login
{
    public class CaptchaDto
    {
        public string CaptchaCode { get; set; } = string.Empty;

        public string ImageBase64 { get; set; } = string.Empty;
    }
}
