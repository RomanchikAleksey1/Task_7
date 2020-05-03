using System;
using Task_7.DbConfiguration;
using Task_7.Interfaces;

namespace Task_7.Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private readonly AppDbContext _appDbContext;
        private IBookRepository _bookRepository;
        private IAuthorRepository _authorRepository;
        private IPublishingHouseRepository _publishingHouseRepository;

        public IBookRepository BookRepository
        {
            get => _bookRepository ??= new BookRepository(_appDbContext);
            set => throw new NotImplementedException();
        }

        public IAuthorRepository AuthorRepository
        {
            get => _authorRepository ??= new AuthorRepository(_appDbContext);
            set => throw new NotImplementedException();
        }

        public IPublishingHouseRepository PublishingHouseRepository
        {
            get => _publishingHouseRepository ??= new PublishingHouseRepository(_appDbContext);
            set => throw new NotImplementedException();
        }

        public RepositoryWrapper(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
    }
}
