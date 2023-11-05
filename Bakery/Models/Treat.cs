using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bakery.Models
{
    public class Treat
    {
        public int TreatId { get; set; }
        [Required(ErrorMessage = "Please enter treat's description to continue.")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Please enter treat's name to continue.")]
        public string Name { get; set; }
        public List<TreatFlavor> JoinEntities { get; }
    }
}