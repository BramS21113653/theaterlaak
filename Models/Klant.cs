using Microsoft.AspNetCore.Identity;
using System.Collections;

public class Klant : IdentityUser {
    public int leeftijdscategorie { get; set; }
    public ArrayList interesses = new ArrayList();
    public string adres { get; set;}
    public DateTime geboortedatum { get; set; }

    public void addInteresse(string interesse) {
        interesses.Add(interesse);
    }

}