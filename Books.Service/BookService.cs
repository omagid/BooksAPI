using System;
using System.Collections.Generic;
using System.Text;
using Books.Data;
using Books.Repository;

namespace Books.Service
{
    public class BookService : IBookService
    {
        private IRepository<Book> _bookRepository;
            
        public BookService(IRepository<Book> bookRepository)
        {
            this._bookRepository = bookRepository;
        }

        public IEnumerable<Book> GetBooks()
        {
            return _bookRepository.GetAll();
        }

        public Book GetBook(long id)
        {
            return _bookRepository.Get(id);
        }

        public void InsertBook(Book book)
        {
            _bookRepository.Insert(book);
        }

        public void UpdateBook(Book book)
        {
            _bookRepository.Update(book);
        }

        public void DeleteBook(long id)
        {
            Book book = GetBook(id);
            _bookRepository.Delete(book);
        }
    }
}
