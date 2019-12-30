namespace CfErpApp.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CfErpApp.Model.CfErpContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;   //datadan değişiklik/silme işlemi yapmaya izin ver.
        }

        protected override void Seed(CfErpApp.Model.CfErpContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            if (!context.tblUsers.Any())
            {
                context.tblUsers.Add(new Model.tblUsers() { UserName = "Mehmet", Sifre = "12345", Role = 1 });
                context.SaveChanges();
            }
            if (!context.menseis.Any()) //Eğer mensei tablosu boş ise
            {
                context.menseis.Add(new Model.Mensei() { MenseiAdi = "Belirtilmemiş" });
                context.menseis.Add(new Model.Mensei() { MenseiAdi = "Türk Malı" });
                context.menseis.Add(new Model.Mensei() { MenseiAdi = "PRC" });
                context.menseis.Add(new Model.Mensei() { MenseiAdi = "Kore" });
                context.menseis.Add(new Model.Mensei() { MenseiAdi = "Germany" });
            }
            context.SaveChanges();
        }
    }
}
