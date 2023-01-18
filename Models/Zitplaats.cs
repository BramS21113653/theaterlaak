public class Zitplaats {
    public int stoelnummer { get; set; }
    public int rangnummer { get; set; }
    public Zaal zaal;
    public Zitplaats (Zaal zaal) {
        this.zaal = zaal;
    }
}