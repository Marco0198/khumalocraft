﻿namespace KhumaloCraft.Web.Repositories
{
    public interface IImageRespository
    {
        Task<string> UploadAsync(IFormFile file);
    }
}
