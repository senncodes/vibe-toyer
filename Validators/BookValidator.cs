using FluentValidation;
using BookRentalApi.Models;
using System;

public class BookValidator : AbstractValidator<Book>
{
    public BookValidator()
    {
        RuleFor(b => b.Title).NotEmpty().WithMessage("Title is required.");
        RuleFor(b => b.Author).NotEmpty().WithMessage("Author is required.");
        RuleFor(b => b.PublishedDate).LessThanOrEqualTo(DateTime.Now).WithMessage("Published date must be in the past.");
    }
}
