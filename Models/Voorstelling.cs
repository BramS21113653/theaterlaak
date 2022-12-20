using System.Collections;

public class Voorstelling {
    public string type { get; set; }
    public ArrayList groepen = new ArrayList();
    public string titel { get; set; }
    public string omschrijving { get; set; }
    public int prijs { get; set; }
    public void addGroep(string groep) {
        groepen.Add(groep);
    }

}