using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Category
{
    [Key]
    public int Id { get; set; }

    [Required]
    [Display(Name = "Name Token")]
    public string NameToken { get; set; }

    [Display(Name = "Type")]
    public int CategoryTypeId { get; set; }

    public CategoryType Type { get; set; }

    [Display(Name = "Description")]
    public string Description { get; set; }

    public List<Book> Books { get; set; }
}
