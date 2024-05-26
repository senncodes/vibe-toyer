using System.Collections.Generic;
using System;

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public DateTime PublishedDate { get; set; }
    public int LibraryId { get; set; }
    public Library Library { get; set; }
    public ICollection<Rental> Rentals { get; set; }
}
