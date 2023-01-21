using Microsoft.AspNetCore.Identity;
namespace theaterlaak.Models;
public class ApplicationUser : IdentityUser
{
    public int? leeftijdscategorie { get; set; }
    public List<Interesse>? interesses { get; set; }
    public string? adres { get; set;}
    public DateTime? geboortedatum { get; set; }

    // public void addInteresse(string interesse) {
    //     interesses.Add(interesse);
    // }
}

