namespace ColectieMuzeeApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Second : DbMigration
    {
        public override void Up()
        {
            DropColumn("Colectie.Judet", "Cod");
        }
        
        public override void Down()
        {
            AddColumn("Colectie.Judet", "Cod", c => c.Int());
        }
    }
}
