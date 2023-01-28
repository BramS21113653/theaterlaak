using System.ComponentModel.DataAnnotations;
namespace theaterlaak.Models;
public class Betaling {
    [Key]
    public string reference { get; set; }
    public Boolean succes { get; set;}
    public string account { get; set; }
}