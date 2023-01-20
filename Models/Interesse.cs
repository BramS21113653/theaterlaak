using System.ComponentModel.DataAnnotations;
namespace theaterlaak.Models;
public class Interesse {
    [Key]
    public int InteresseId { get; set; }
    public string interesse { get; set; }
}