namespace ColectieMuzeeApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FourthMigration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("Colectie.Muzeu", "Denumire", c => c.String(nullable: false, maxLength: 50));
            CreateIndex("Colectie.Muzeu", "Denumire", unique: true, name: "DenumireMuzeu");
        }
        
        public override void Down()
        {
            DropIndex("Colectie.Muzeu", "DenumireMuzeu");
            AlterColumn("Colectie.Muzeu", "Denumire", c => c.String(maxLength: 50));
        }
    }
}
