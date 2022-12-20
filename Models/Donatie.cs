 public class Donatie {
    public DateTime datum { get; set; }
    public int bedrag { get; set; }
    public Begunstiger begunstiger;
    public void createBegunstiger(Begunstiger begunstiger) {
        this.begunstiger = begunstiger;
    }
}