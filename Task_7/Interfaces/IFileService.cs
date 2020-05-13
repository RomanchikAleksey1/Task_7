using Microsoft.AspNetCore.Http;

namespace Task_7.Interfaces
{
    public interface IFileService
    {
        void SaveUploadedFile(IFormFile uploadedFile, string path);
        void DeleteFile(string path);
    }
}