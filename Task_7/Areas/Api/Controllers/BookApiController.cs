using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Task_7.Interfaces;
using Task_7.Models;

namespace Task_7.Areas.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookApiController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;

        public BookApiController(IRepositoryWrapper repositoryWrapper)
        {
            _bookRepository = repositoryWrapper.BookRepository;
        }

        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return _bookRepository.FindAll();
        }


        [HttpGet("{id}", Name = "Get")]
        public Book Get(Guid id)
        {
            return _bookRepository.FindByCondition(x => x.Id == id).FirstOrDefault();
        }

    }
}
