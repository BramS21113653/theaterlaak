
using System.Collections;
public class Gelegenheid {
    public Voorstelling voorstelling;
    public DateTime aanvangstijd { get; set; }
    public DateTime eindtijd { get; set; }
    //zitplaatsen setten met beschikbarenplaatsen uit zaal
    public ArrayList zitplaatsenBeschikbaar;
    public Zaal zaal;
    public Gelegenheid(Voorstelling voorstelling, Zaal zaal) {
        this.voorstelling = voorstelling;
        this.zaal = zaal;
        this.zitplaatsenBeschikbaar = new ArrayList();
        //zitplaatsen uit db halen van betreffende zaal
        this.zitplaatsenBeschikbaar.Add("fixme");
    }
}