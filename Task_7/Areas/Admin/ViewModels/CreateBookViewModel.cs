using Microsoft.AspNetCore.Http;
using Task_7.Models;

namespace Task_7.Areas.Admin.ViewModels
{
    public class CreateBookViewModel
    {
        public Book Book { get; set; }
        public IFormFile UploadedFile { get; set; }
    }
}
