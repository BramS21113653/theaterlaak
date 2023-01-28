using System.ComponentModel.DataAnnotations;
namespace theaterlaak.Models;
public class Boeking {
    [Key]
    public string boekingId { get; set; }
    public int UserId { get; set;}
    public ApplicationUser applicationUser { get; set; }
    public string zaalId { get; set;}
    public Zaal zaal { get; set; }
    public List<Ticket>? tickets { get; set; }
    public string gelegenheidId { get; set; }
    public Gelegenheid gelegenheid { get; set; }
}