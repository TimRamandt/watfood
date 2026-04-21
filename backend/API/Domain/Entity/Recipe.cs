using System.ComponentModel.DataAnnotations;

namespace backend.Domain.Entity;

public class Recipe
{
    [Key]
    public int Id { get; set; }

    public string Name { get; set; }
    
}