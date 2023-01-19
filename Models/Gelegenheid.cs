
using System.Collections;
using System.ComponentModel.DataAnnotations;

public class Gelegenheid {
    [Key]
    public string GelegenheidId { get; set; }
    public DateTime aanvangstijd { get; set; }
    public DateTime eindtijd { get; set; }
    //zitplaatsen setten met beschikbarenplaatsen uit zaal
    // public ArrayList zitplaatsenBeschikbaar { get; set; }
    public string VoorstellingId { get; set; }
    public Voorstelling voorstelling { get; set; }
    // foreign key
    public string ZaalId { get; set;}
    // reference navigation property
    public Zaal zaal { get; set; }

    //constructor overbodig met properties
    // public Gelegenheid(Voorstelling voorstelling, Zaal zaal) {
    //     this.voorstelling = voorstelling;
    //     this.zaal = zaal;
    //     this.zitplaatsenBeschikbaar = new ArrayList();
    //     //zitplaatsen uit db halen van betreffende zaal
    //     this.zitplaatsenBeschikbaar.Add("fixme");
    // }
}