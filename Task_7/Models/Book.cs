using System;
using System.Collections.Generic;

namespace Task_7.Models
{
    public class Book
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime? PublicationDate { get; set; }

        public double? Rating { get; set; }

        public string ImageLink { get; set; }

        public Guid? PublishingHouseId { get; set; }

        public PublishingHouse PublishingHouse { get; set; }

        public List<BookAuthor> BookAuthors { get; set; }

        public string GetPublicationDateByFormat(string format = "MM d, yyyy")
        {
            return PublicationDate?.ToString(format) ?? string.Empty;
        }

    }
}

