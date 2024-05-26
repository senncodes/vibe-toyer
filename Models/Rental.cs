using System;

public class Rental
{
    public int Id { get; set; }
    public int BookId { get; set; }
    public Book Book { get; set; }
    public string RentedBy { get; set; }
    public DateTime RentedOn { get; set; }
}
