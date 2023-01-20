using System.ComponentModel.DataAnnotations;
namespace theaterlaak.Models;
public class Voorstelling {
    [Key]
    public string voorstellingId { get; set; }
    public string voorstellingType { get; set; }
    public List<Groep> Groepen { get; set; }
    public string titel { get; set; }
    public string omschrijving { get; set; }
    public int prijs { get; set; }
    public List<Ticket> tickets { get; set; }
    public List<Gelegenheid> gelegenheden { get; set; }
    // public void addGroep(Groep groep) {
    //     groepen.Add(groep);
    // }
}