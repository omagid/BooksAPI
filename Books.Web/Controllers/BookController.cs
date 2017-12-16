using System.Collections.Generic;
using AutoMapper;
using Books.Service;
using Books.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Books.Web.Controllers
{
    [Produces("application/json")]
    [Route("api/Book")]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;
        private readonly IMapper _mapper;

        public BookController(IBookService bookService, IMapper mapper)
        {
            _bookService = bookService;
            _mapper = mapper;
        }

        // GET: api/Book
        [HttpGet]
        public IActionResult Get()
        {
            var books = _bookService.GetBooks();
            var result = _mapper.Map<IEnumerable<BookViewModel>>(books);
            return Ok(result);
        }

        // GET: api/Book/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/Book
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/Book/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
