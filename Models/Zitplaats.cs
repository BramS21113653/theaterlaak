using System.ComponentModel.DataAnnotations;
namespace theaterlaak.Models;
public class Zitplaats {
    [Key]
    public string zitplaatsId { get; set; }
    public int stoelnummer { get; set; }
    public int rangnummer { get; set; }
    public int soortZitplaats { get; set; }
    public string zaalId { get; set;}
    public Zaal zaal;
    public List<Ticket>? tickets { get; set; }
    // public Zitplaats (Zaal zaal) {
    //     this.zaal = zaal;
    // }
}