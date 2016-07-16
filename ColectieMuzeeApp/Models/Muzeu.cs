using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ColectieMuzeeApp.ColectieContext;

namespace ColectieMuzeeApp.Models
{
    [Table("Muzeu", Schema = "Colectie")]
    public class Muzeu 
    {
        [Key]
        [Required]
        public virtual int Id { get; set; }

        [MaxLength(50)]
        public virtual string Denumire { get; set; }

        public virtual decimal? NumarStele { get; set; }
               
        public virtual int BilantViziteId { get; set; }
        [ForeignKey("BilantViziteId")]
        public virtual BilantVizite BilantVizite { get; set; }

        public virtual int LocalitateId { get; set; }
        [ForeignKey("LocalitateId")]
        public virtual Localitate Localitate { get; set; }

        public virtual ICollection<ProfilGeneral> ProfilGeneral { get; set; }
    }
}
