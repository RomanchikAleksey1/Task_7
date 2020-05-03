﻿namespace Task_7.Interfaces
{
    public interface IRepositoryWrapper
    {
        IBookRepository BookRepository { get; set; }

        IAuthorRepository AuthorRepository { get; set; }

        IPublishingHouseRepository PublishingHouseRepository { get; set; }
    }
}