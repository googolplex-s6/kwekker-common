using System.ComponentModel.DataAnnotations;

namespace KwekkerCommon.DTOs;

public class KwekInputDTO
{
    [Required]
    [StringLength(256, MinimumLength = 1)]
    public string Text { get; set; }
}