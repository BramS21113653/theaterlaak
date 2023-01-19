using System.ComponentModel.DataAnnotations;

public class Groep {
    [Key]
    public string GroepId { get; set; }
    public string naam { get; set; }
    public string website { get; set; }
    // public List<ApplicationUser> ApplicationUsers { get; set; }
}