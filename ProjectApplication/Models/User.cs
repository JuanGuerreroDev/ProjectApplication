using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectApplication.Models;

[Table("users")]

public class User
{
    [Key]
    public int? id { get; set; }
    
    [Required]
    public string? name { get; set; }
    
    [Required]
    public string? email { get; set; }
    
    [Required]
    public string? password { get; set; }
}