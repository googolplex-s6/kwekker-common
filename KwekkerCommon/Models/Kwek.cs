using System.ComponentModel.DataAnnotations;

namespace KwekkerCommon.Models;

public class Kwek
{
    public int Id { get; set; }
    
    public User User { get; set; }
    
    [Required]
    public string Text { get; set; }
    
    public DateTime PostedAt { get; set; }
}