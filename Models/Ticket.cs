using System.ComponentModel.DataAnnotations;
    public class Ticket {
    [Key]
    public string TicketId { get; set;}
    public string ZitplaatsId { get; set;}
    public Zitplaats zitplaats { get; set; }
    public string VoorstellingId { get; set;}
    public Voorstelling voorstelling { get; set; }
    public double prijs { get; set; }
    // public string KlantId { get; set;}
    // public Klant klant { get; set; }
    public string ZaalId { get; set;}
    public Zaal zaal { get; set; }

    // public void addGroep(Ticket ticket) {
    //     // tickets.Add(ticket);
    // }
}
