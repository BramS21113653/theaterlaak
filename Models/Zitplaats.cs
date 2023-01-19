using System.ComponentModel.DataAnnotations;

public class Zitplaats {
    [Key]
    public string ZitplaatsId { get; set; }
    public int stoelnummer { get; set; }
    public int rangnummer { get; set; }
    public string ZaalId { get; set;}
    public Zaal zaal;
    public List<Ticket> Tickets { get; set; }
    // public Zitplaats (Zaal zaal) {
    //     this.zaal = zaal;
    // }
}