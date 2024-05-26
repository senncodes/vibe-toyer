using System.Collections.Generic;
using System.Linq;
using BookRentalApi.Models;
using Microsoft.EntityFrameworkCore;

public class BookService : IBookService
{
    private readonly BookRentalContext _context;

    public BookService(BookRentalContext context)
    {
        _context = context;
    }

    public IEnumerable<Book> GetAll()
    {
        return _context.Books.Include(b => b.Library).ToList();
    }

    public Book GetById(int id)
    {
        return _context.Books.Include(b => b.Library).FirstOrDefault(b => b.Id == id);
    }

    public void Add(Book book)
    {
        _context.Books.Add(book);
        _context.SaveChanges();
    }

    public void Update(Book book)
    {
        _context.Entry(book).State = EntityState.Modified;
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        var book = _context.Books.Find(id);
        if (book != null)
        {
            _context.Books.Remove(book);
            _context.SaveChanges();
        }
    }
}
