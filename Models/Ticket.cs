namespace theaterlaak.Models
{
    public class Ticket
    {
    public Zitplaats zitplaats;
    public Voorstelling voorstelling;
    public double prijs;
    public Klant klant;
    public Zaal zaal;

    public void addGroep(Ticket ticket) {
        tickets.Add(ticket);
    }
}
}