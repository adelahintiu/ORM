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
    [Table("ProfilGeneral", Schema = "Colectie")]
    public class ProfilGeneral
    {
        [Key]
        [Required]
        public virtual int Id { get; set; }

        [MaxLength(35)]
        public virtual string Denumire { get; set; }

        public virtual ICollection<Muzeu> Muzeu { get; set; }
    }
}
