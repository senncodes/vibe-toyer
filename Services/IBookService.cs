using BookRentalApi.Models;
using System.Collections.Generic;

public interface IBookService
{
	IEnumerable<Book> GetAll();
	Book GetById(int id);
	void Add(Book book);
	void Update(Book book);
	void Delete(int id);
}
