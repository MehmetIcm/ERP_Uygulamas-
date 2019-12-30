namespace CfErpApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPersonelTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Personels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PersonelNo = c.String(),
                        Ad = c.String(),
                        Tel = c.String(),
                        Gsm = c.String(),
                        Adres = c.String(),
                        IsBasiTarih = c.DateTime(nullable: false),
                        IsSonTarih = c.DateTime(nullable: false),
                        DogumTarih = c.DateTime(nullable: false),
                        Email = c.String(),
                        TcNo = c.String(),
                        Yetki = c.String(),
                        CinsiyetId = c.Boolean(nullable: false),
                        MedeniHal = c.Boolean(nullable: false),
                        DepartmanId = c.Int(nullable: false),
                        UnvanId = c.Int(nullable: false),
                        Image = c.Binary(),
                    })
                .PrimaryKey(t => t.Id);
        }
        
        public override void Down()
        {
            DropTable("dbo.Personels");
        }
    }
}
