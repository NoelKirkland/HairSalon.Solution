using System.ComponentModel;

namespace HairSalon.Models
{
  public class Client
  {
    public string Name { get; set; }
    [DisplayName("phone number")]
    public int PhoneNumber { get; set; }
    public int ClientId { get; set; }
    public int StylistId { get; set; }
    public virtual Cuisine Cuisine { get; set; }
  }
}