using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColectieMuzeeApp.Models
{
    [Table("BilantVizite", Schema = "Colectie")]
    public class BilantVizite
    {
        [Key]
        public virtual int BilantViziteId { get; set; }

        public virtual int NumarVizite { get; set; }

        public virtual DateTime Data { get; set; }
    }
}
