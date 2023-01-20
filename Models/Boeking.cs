using System.ComponentModel.DataAnnotations;
namespace theaterlaak.Models;
public class Boeking {
    [Key]
    public string BoekingId { get; set; }
    public int UserId { get; set;}
    public ApplicationUser applicationUser { get; set; }
    public string ZaalId { get; set;}
    public Zaal zaal { get; set; }
    public List<Ticket> Tickets { get; set; }

    // public void addGroep(Ticket ticket) {
    //     tickets.Add(ticket);
    // }
}