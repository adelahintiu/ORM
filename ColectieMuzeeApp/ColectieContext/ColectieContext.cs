using ColectieMuzeeApp.Models;
using ColectieMuzeeApp.Models.Nomenclatures;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.ComponentModel.DataAnnotations.Schema;

namespace ColectieMuzeeApp.ColectieContext
{
    public class ColectieContext : DbContext
    {
        public ColectieContext() : base("Colectie")
        {
            Init();
        }

        private void Init()
        {
            Configuration.LazyLoadingEnabled = true;
            Configuration.ProxyCreationEnabled = true;
        }

        public DbSet<Muzeu> Muzeu { get; set; }
        public DbSet<BilantVizite> BilantVizite { get; set; }
        public DbSet<ProfilGeneral> ProfilGeneral { get; set; }
        public DbSet<Judet> Judet { get; set; }
        public DbSet<Localitate> Localitate { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

           
            ApplyCustomConventions(modelBuilder);

            modelBuilder.Entity<Muzeu>().Property(x => x.Denumire).IsRequired().HasMaxLength(50)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(
                        new IndexAttribute("DenumireMuzeu") { IsUnique = true }));


            modelBuilder.Entity<Muzeu>()
                .HasMany<ProfilGeneral>(s => s.ProfilGeneral)
                .WithMany(c => c.Muzeu)
                .Map(cs =>
                {
                    cs.MapLeftKey("MuzeuId");
                    cs.MapRightKey("ProfilGeneralId");
                    cs.ToTable("MuzeuProfilGeneral", "Colectie");
                });
        }

        private void ApplyCustomConventions(DbModelBuilder modelBuilder)
        {
            modelBuilder.Properties<decimal>().Configure(c => c.HasPrecision(10, 2));
            modelBuilder.Properties<string>().Configure(x => x.HasMaxLength(150));
        }

        
    }
}
