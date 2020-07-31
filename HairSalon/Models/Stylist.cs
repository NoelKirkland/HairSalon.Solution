using System.Collections.Generic;
using System.ComponentModel;


namespace HairSalon.Models
{
  public class Stylist
  {
    public Stylist()
    {
      this.Clients = new HashSet<Client>();
    }
    // [DisplayName("Name of Stylist")]
    public string Name { get; set; }
    public int StationNumber { get; set; }
    public string Specialty { get; set; }
    public int StylistId { get; set; }
    public virtual ICollection<Client> Clients { get; set; }
  }
}