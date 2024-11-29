using MyEducatin.Models;

namespace MyEducatin.Repositories.BookRep
{
    public interface IBookRepository
    {
        List<Book> GetBookAll();
        Book GetBookById(int id);
        Book AddBook(Book book);
        void DeleteBook(int id);
    }
}
