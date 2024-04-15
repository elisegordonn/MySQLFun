using System.ComponentModel.DataAnnotations;

namespace MySQLFun.Models;

public class Recipe
{
    [Key]
    [Required]
    public int RecipeID { get; set; } //if you leave the set; off, it becomes a read-only variable
    public string RecipeTitle { get; set; }
    public int RecipeClassID { get; set; }
    public string Preparation { get; set; }
    public string Notes { get; set; }
}