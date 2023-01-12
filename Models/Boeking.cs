public class Boeking {
    public Klant klant;
    public Zaal zaal;
    public ArrayList tickets = new ArrayList();

    public void addGroep(Ticket ticket) {
        tickets.Add(ticket);
    }
}