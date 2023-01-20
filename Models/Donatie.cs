 using System.ComponentModel.DataAnnotations;
 namespace theaterlaak.Models;
 public class Donatie {
    [Key]
    public string donatieId { get; set; }
    public DateTime datum { get; set; }
    public int bedrag { get; set; }
    // public string KlantId { get; set;}
    // public Klant klant { get; set; }
}