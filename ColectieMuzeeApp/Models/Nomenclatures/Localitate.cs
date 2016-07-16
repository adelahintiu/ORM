using ColectieMuzeeApp.Models.Nomenclatures;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColectieMuzeeApp.Models
{
    [Table("Localitate", Schema = "Colectie")]
    public class Localitate
    {
        [Index("LocalitateIdentificator", 1, IsUnique = true)]
        public virtual int Id { get; set; }

        [Index("LocalitateIdentificator", 2, IsUnique = true)]
        public virtual int Cod { get; set; }

        [MaxLength(50)]
        public virtual string Denumire { get; set; }

        public virtual int JudetId { get; set; }
        [ForeignKey("JudetId")]
        public virtual Judet Judet { get; set; }

    }
}
