using System.ComponentModel.DataAnnotations;

namespace BlazorServerMessageWall.Models;

public class MessageModel
{
    [Required]
    [StringLength(maximumLength:10, MinimumLength = 5)]
    public string Message { get; set; }
}
