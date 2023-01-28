
using System.ComponentModel.DataAnnotations;
namespace theaterlaak.Models;
public class Gelegenheid {
    [Key]
    public string gelegenheidId { get; set; }
    public DateTime aanvangstijd { get; set; }
    public DateTime eindtijd { get; set; }
    //zitplaatsen setten met beschikbarenplaatsen uit zaal
    // public ArrayList zitplaatsenBeschikbaar { get; set; }
    public string voorstellingId { get; set; }
    public Voorstelling voorstelling { get; set; }
    // foreign key
    public string zaalId { get; set;}
    // reference navigation property
    public Zaal zaal { get; set; }
}