namespace ColectieMuzeeApp.Migrations
{
    using Models;
    using Models.Nomenclatures;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using ColectieContext;

    internal sealed class Configuration : DbMigrationsConfiguration<ColectieMuzeeApp.ColectieContext.ColectieContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ColectieMuzeeApp.ColectieContext.ColectieContext context)
        {
            PopulateJudetList(context);
        }

        private void PopulateJudetList(ColectieContext context)
        {
            var judetList = new List<Judet>
            {
                new Judet { Denumire = "Arges" },
                new Judet { Denumire = "Bucuresti"},
                new Judet { Denumire = "Alba"},
                new Judet { Denumire = "Sibiu"}
            };

            foreach (var judet in judetList)
            {
                context.Judet.AddOrUpdate(p => p.Denumire, judet);
            }
        }
    }
}
