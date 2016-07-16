using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ColectieMuzeeApp.Models.Nomenclatures;
using System.ComponentModel.DataAnnotations.Schema;

namespace ColectieMuzeeApp.Models.Nomenclatures
{
    [Table("Judet", Schema = "Colectie")]
    public class Judet
    {
        [Key]
        [Required]
        public virtual int Id { get; set; }

        [MaxLength(50)]
        public virtual string Denumire { get; set; }

    }
}
