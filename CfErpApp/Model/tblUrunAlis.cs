using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CfErpApp.Model
{
    public class tblUrunAlis:BaseEntity //1.Public class et 2.Base Entity'i miras al
    {
        public string UrunAlisNo { get; set; }

        public int TblCariId { get; set; } //3. prop tab tab cariID
        public virtual tblCari TblCari { get; set; }   //4. Cari bilgileri çektik foreign key ile

        public int PersonelId { get; set; }
        public virtual Personel Personel { get; set; }  //5.Kaydı yapacak kişi 

        public string FaturaNo { get; set; }
        public DateTime AlisTarih { get; set; }

        public int? TblUrunId { get; set; }  //6.Ürün girişlerinden bilgileri çektik. TblUrunlerId boş(null) gelmesi durumunda sistem çöküyor yanına soru işareti koyarak null gelebilecğeine izin ver
        public virtual tblUrunler TblUrun { get; set; }

        public decimal BFiyat { get; set; }
        public decimal KdvTutar { get; set; }

        public int Miktar { get; set; }

        public decimal AraToplam { get; set; }
        public decimal KdvToplam { get; set; }
        public decimal TutarToplam { get; set; }
        //7. CfErpContext'e gidip public DbSet<tblUrunAlis> tblUrunAlis { get; set; }
    }
}
