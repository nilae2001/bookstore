using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Bookstore.Models;

public class Book
{
    public int Id { get; set; }
    [Required]
    public string Title { get; set; }
    public string CoverImageUrl { get; set; }
    [Display(Name = "Cover Image")]

    public string Author { get; set; }
    [Required]

    public string Genre { get; set; }

    public string Publisher { get; set; }

    public int PublicationYear { get; set; }
    [Display(Name  = "Publication Year")]

    public string Language { get; set; }

    public int PageCount { get; set; }
    [Range(0, 100)]
    [DataType(DataType.Currency)]
    [Column(TypeName = "decimal(28, 2)")]

    public decimal Price { get; set; }
}