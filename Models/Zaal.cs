using System.ComponentModel.DataAnnotations;
namespace theaterlaak.Models;
public class Zaal {
    [Key]
    public String ZaalId { get; set; }
    public int zaalnummer { get; set; }
    public int aantalZitplaatsen { get; set; }
    public List<Gelegenheid> Gelegenheden { get; set; }
    public List<Ticket> Tickets { get; set; }
    public List<Zitplaats> Zitplaatsen { get; set; }
    public List<Boeking> Boekingen { get; set; }
}