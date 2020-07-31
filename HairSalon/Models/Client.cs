using System.ComponentModel;

namespace HairSalon.Models
{
  public class Client
  {
    public string Name { get; set; }
    [DisplayName("phone number")]
    public string PhoneNumber { get; set; }
    public int ClientId { get; set; }
    public int StylistId { get; set; }
    public virtual Stylist Stylist { get; set; }
  }
}