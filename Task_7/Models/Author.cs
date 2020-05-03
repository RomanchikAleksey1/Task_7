using System;
using System.Collections.Generic;

namespace Task_7.Models
{
    public class Author
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public List<BookAuthor> BookAuthors { get; set; }

    }
}
