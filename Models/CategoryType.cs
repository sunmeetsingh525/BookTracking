using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class CategoryType
{
    [Key]
    public int Id { get; set; }

    [Required]
    [Display(Name = "Type")]
    public string Type { get; set; }

    [Required]
    [Display(Name = "Name")]
    public string Name { get; set; }

    public List<Category> Categories { get; set; }
}
