 using System.ComponentModel.DataAnnotations;
 public class Donatie {
    [Key]
    public string DonatieId { get; set; }
    public DateTime datum { get; set; }
    public int bedrag { get; set; }
    // public string KlantId { get; set;}
    // public Klant klant { get; set; }
}