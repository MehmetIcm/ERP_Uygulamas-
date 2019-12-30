using CfErpApp.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CfErpApp.Model
{
    public class CfErpContext:DbContext
    {
        public DbSet<Personel> Personels { get; set; }
        public DbSet<Departman> Departmen { get; set; }
        public DbSet<Unvan> Unvans { get; set; }
        public DbSet<tblCari> tblCaris { get; set; }
        public DbSet<tblCariTur> tblCariTurs { get; set; }
        public DbSet<tblUrunler> tblUrunler { get; set; }
        public DbSet<Kategori> kategoris { get; set; }
        public DbSet<Mensei> menseis { get; set; }
        public DbSet<tblUrunAlis> tblUrunAlis { get; set; }
        public DbSet<tblUrunSatis> tblUrunSatis { get; set; }
        public DbSet<tblStokDurum> tblStokDurums { get; set; }
        public DbSet<tblUsers> tblUsers { get; set; }


        public CfErpContext():base("DefCon")   //database ile connection string arasında köprü görevi görür. Çalışması için connection stringdeki add name alınır
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<CfErpContext, Configuration>("DefCon")); //Databasedeki ufak değişiklikler yerleri tespit edilerek değiştirilir.
        }
        public static CfErpContext Create() //proje çalıştırıldığında databasei oluştursun diye kullandığımız bir şablon.
        {
            return new CfErpContext();
        }
    }
}
