 public class Donatie {
    public DateTime datum { get; set; }
    public int bedrag { get; set; }
    public Klant klant;
    public void createklant(Klant klant) {
        this.klant = klant;
    }
}