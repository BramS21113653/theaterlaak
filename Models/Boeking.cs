public class Boeking {
    public Klant klant;
    public Zaal zaal;
    public Voorstelling? voorstelling;
    public Zitplaats? zitplaats;

    public Boeking (Klant klant, Zaal zaal, Voorstelling voorstelling, Zitplaats zitplaats) {
        this.klant = klant;
        this.zaal = zaal;
        this.voorstelling = voorstelling;
        this.zitplaats = zitplaats;
    }
}