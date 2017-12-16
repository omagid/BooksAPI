using Books.Data;
using System.Collections.Generic;

namespace Books.Service
{
    public interface IBookService
    {
        IEnumerable<Book> GetBooks();
        Book GetBook(long id);
        void InsertBook(Book book);
        void UpdateBook(Book book);
        void DeleteBook(long id);
    }
}
