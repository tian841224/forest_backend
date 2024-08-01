﻿using CommonLibrary.DTOs.File;
using Humanizer;
using Microsoft.AspNetCore.Http;

namespace CommonLibrary.Service
{
    /// <summary>
    /// 檔案處理
    /// </summary>
    public class FileService
    {
        private readonly string _fileUploadPath = Path.Combine(Directory.GetCurrentDirectory(), "Files");


        public async Task<FileUploadDto> UploadFile(IFormFile FormFile, string? FileUploadPath = null)
        {
            if (FileUploadPath == null)
                FileUploadPath = _fileUploadPath;

            var filePath = Path.Combine(FileUploadPath, FormFile.FileName);

            //檢查目錄
            if (!Directory.Exists(_fileUploadPath))
            {
                Directory.CreateDirectory(_fileUploadPath);
            }

            //上傳檔案
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await FormFile.CopyToAsync(stream);
            }

            return new FileUploadDto
            {
                FileName = FormFile.FileName,
                FilePath = filePath,
            };
        }

        /// <summary>
        /// IFormFile轉換成base64
        /// </summary>
        /// <param name="formFile"></param>
        /// <returns></returns>
        public async Task<string> FileToBase64(IFormFile formFile)
        {
            string filePath = Path.GetTempFileName();

            using(var stream = File.Create(filePath))
            {
                await formFile.CopyToAsync(stream);
            }

            var file = await File.ReadAllBytesAsync(filePath);

            //轉成base64
            return Convert.ToBase64String(file);
        }

        /// <summary>
        /// 檔案轉換成base64
        /// </summary>
        /// <param name="formFile"></param>
        /// <returns></returns>
        public async Task<string> FileToBase64(string filePath)
        {
            using (var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                using (var memoryStream = new MemoryStream())
                {
                    await stream.CopyToAsync(memoryStream);
                    return Convert.ToBase64String(memoryStream.ToArray());
                }
            }
        }

        /// <summary>
        /// 檔案轉換成byte[]
        /// </summary>
        /// <param name="formFile"></param>
        /// <returns></returns>
        public async Task<byte[]> FileToByte(string filePath)
        {
            using (var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                using (var memoryStream = new MemoryStream())
                {
                    await stream.CopyToAsync(memoryStream);
                    return memoryStream.ToArray();
                }
            }
        }
    }
}
