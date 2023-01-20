using System.ComponentModel.DataAnnotations;
namespace theaterlaak.Models;
public class Voorstelling {
    [Key]
    public string VoorstellingId { get; set; }
    public string type { get; set; }
    public List<Groep> Groepen { get; set; }
    public string titel { get; set; }
    public string omschrijving { get; set; }
    public int prijs { get; set; }
    public List<Ticket> Tickets { get; set; }
    public List<Gelegenheid> Gelegenheden { get; set; }
    // public void addGroep(Groep groep) {
    //     groepen.Add(groep);
    // }
}