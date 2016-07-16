namespace ColectieMuzeeApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Colectie.BilantVizite",
                c => new
                    {
                        BilantViziteId = c.Int(nullable: false, identity: true),
                        NumarVizite = c.Int(nullable: false),
                        Data = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.BilantViziteId);
            
            CreateTable(
                "Colectie.Judet",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Denumire = c.String(maxLength: 50),
                        Cod = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "Colectie.Localitate",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Denumire = c.String(maxLength: 50),
                        JudetId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("Colectie.Judet", t => t.JudetId)
                .Index(t => t.JudetId);
            
            CreateTable(
                "Colectie.Muzeu",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Denumire = c.String(maxLength: 50),
                        NumarStele = c.Decimal(precision: 10, scale: 2),
                        BilantViziteId = c.Int(nullable: false),
                        LocalitateId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("Colectie.BilantVizite", t => t.BilantViziteId)
                .ForeignKey("Colectie.Localitate", t => t.LocalitateId)
                .Index(t => t.BilantViziteId)
                .Index(t => t.LocalitateId);
            
            CreateTable(
                "Colectie.ProfilGeneral",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Denumire = c.String(maxLength: 35),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "Colectie.MuzeuProfilGeneral",
                c => new
                    {
                        MuzeuId = c.Int(nullable: false),
                        ProfilGeneralId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.MuzeuId, t.ProfilGeneralId })
                .ForeignKey("Colectie.Muzeu", t => t.MuzeuId)
                .ForeignKey("Colectie.ProfilGeneral", t => t.ProfilGeneralId)
                .Index(t => t.MuzeuId)
                .Index(t => t.ProfilGeneralId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("Colectie.MuzeuProfilGeneral", "ProfilGeneralId", "Colectie.ProfilGeneral");
            DropForeignKey("Colectie.MuzeuProfilGeneral", "MuzeuId", "Colectie.Muzeu");
            DropForeignKey("Colectie.Muzeu", "LocalitateId", "Colectie.Localitate");
            DropForeignKey("Colectie.Muzeu", "BilantViziteId", "Colectie.BilantVizite");
            DropForeignKey("Colectie.Localitate", "JudetId", "Colectie.Judet");
            DropIndex("Colectie.MuzeuProfilGeneral", new[] { "ProfilGeneralId" });
            DropIndex("Colectie.MuzeuProfilGeneral", new[] { "MuzeuId" });
            DropIndex("Colectie.Muzeu", new[] { "LocalitateId" });
            DropIndex("Colectie.Muzeu", new[] { "BilantViziteId" });
            DropIndex("Colectie.Localitate", new[] { "JudetId" });
            DropTable("Colectie.MuzeuProfilGeneral");
            DropTable("Colectie.ProfilGeneral");
            DropTable("Colectie.Muzeu");
            DropTable("Colectie.Localitate");
            DropTable("Colectie.Judet");
            DropTable("Colectie.BilantVizite");
        }
    }
}
