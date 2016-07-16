namespace ColectieMuzeeApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ThirdMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("Colectie.Localitate", "Cod", c => c.Int(nullable: false));
            CreateIndex("Colectie.Localitate", new[] { "Id", "Cod" }, unique: true, name: "LocalitateIdentificator");
        }
        
        public override void Down()
        {
            DropIndex("Colectie.Localitate", "LocalitateIdentificator");
            DropColumn("Colectie.Localitate", "Cod");
        }
    }
}
