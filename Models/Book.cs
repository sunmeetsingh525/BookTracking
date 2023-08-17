using System.ComponentModel.DataAnnotations;

public class Book
{
    [Key]
    public string ISBN { get; set; }

    [Required]
    [Display(Name = "Title")]
    public string Title { get; set; }

    [Display(Name = "Category")]
    public int CategoryId { get; set; }

    public Category Category { get; set; }

    [Display(Name = "Author")]
    public string Author { get; set; }
}
