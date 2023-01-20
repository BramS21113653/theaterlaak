using System.ComponentModel.DataAnnotations;
namespace theaterlaak.Models;
public class Groep {
    [Key]
    public string groepId { get; set; }
    public string naam { get; set; }
    public string website { get; set; }
    // public List<ApplicationUser> ApplicationUsers { get; set; }
}