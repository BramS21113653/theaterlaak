using System.ComponentModel.DataAnnotations;
namespace theaterlaak.Models;
public class Interesse {
    [Key]
    public string interesse { get; set; }
}