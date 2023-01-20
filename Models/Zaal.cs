using System.ComponentModel.DataAnnotations;
namespace theaterlaak.Models;
public class Zaal {
    [Key]
    public String zaalId { get; set; }
    public int zaalnummer { get; set; }
    public int aantalZitplaatsen { get; set; }
    public List<Gelegenheid> gelegenheden { get; set; }
    public List<Ticket> tickets { get; set; }
    public List<Zitplaats> zitplaatsen { get; set; }
    public List<Boeking> boekingen { get; set; }
}