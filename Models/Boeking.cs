using System.Collections;
using theaterlaak.Models;
using System.ComponentModel.DataAnnotations;
public class Boeking {
    [Key]
    public string BoekingId { get; set; }
    // public string KlantId { get; set;}
    // public Klant klant { get; set; }
    public string ZaalId { get; set;}
    public Zaal zaal { get; set; }
    public List<Ticket> Tickets { get; set; }

    // public void addGroep(Ticket ticket) {
    //     tickets.Add(ticket);
    // }
}