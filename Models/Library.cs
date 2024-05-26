using System.Collections.Generic;

public class Library
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Location { get; set; }
    public ICollection<Book> Books { get; set; }
}
