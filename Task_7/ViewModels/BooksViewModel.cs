using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Task_7.Models;

namespace Task_7.ViewModels
{
    public class BooksViewModel
    {
        public const string AllPublishingHouses = "All";

        public List<Book> Books { get; set; }
        public SelectList PublishingHouses { get; set; }
        public string SelectedPublishingHouse { get; set; }
    }
}
