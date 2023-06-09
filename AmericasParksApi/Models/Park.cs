namespace AmericasParksApi.Models
{
  public class Park
  {
    public int ParkId { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
    public string Location { get; set; }
    public string DateEstablished { get; set; }
    public string Area { get; set; }
    public string Description { get; set; }
  }
}