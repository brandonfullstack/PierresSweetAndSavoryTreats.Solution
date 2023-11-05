using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bakery.Models
{
  public class Flavor
  {
    public int FlavorId { get; set; }
    [Required(ErrorMessage = "Please enter flavor's name to continue.")]
    public string Name { get; set; }
    [Required(ErrorMessage = "Please enter flavor's description to continue.")]
    public string Description { get; set; }
    public List<TreatFlavor> JoinEntities { get; }
  }
}