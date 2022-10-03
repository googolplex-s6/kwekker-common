namespace KwekkerCommon.DTOs;

public class KwekOutputDTO
{
    public int Id { get; set; }
    
    public UserOutputDTO User { get; set; }
    
    public string Text { get; set; }
    
    public DateTime PostedAt { get; set; }
}