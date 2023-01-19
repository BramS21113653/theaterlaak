using System.Collections;
using theaterlaak.Models;

public class Boeking {
    public string BoekingId { get; set; }
    public Klant klant { get; set; }
    public Zaal zaal { get; set; }
    public ArrayList tickets { get; set; }= new ArrayList();

    // public void addGroep(Ticket ticket) {
    //     tickets.Add(ticket);
    // }
}