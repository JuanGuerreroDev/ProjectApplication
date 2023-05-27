using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NuGet.Protocol;

namespace ProjectApplication.Models;

[Table("request_service")]
public class RequestService
{
    [Key]
    public int? id { get; set; }
    
    [Required]
    public string? name { get; set; }
    
    [Required]
    public string? email { get; set; }
    
    [Required]
    public string? phone { get; set; }
    
    [Required]
    public bool? is_finished { get; set; }
    
    [Required]
    public int? service_type_id { get; set; }

    [Required] 
    public int? track_type_id { get; set; }
}