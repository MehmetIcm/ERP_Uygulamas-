using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CfErpApp.Model
{
    public class tblStokDurum:BaseEntity
    {
        public int StokKodu { get; set; }
        public string Barkod { get; set; }
        public int UrunId { get; set; }
        public virtual tblUrunler Urun{ get; set; } //UrunId ve Urun isminin benzer olması lazım. Foreign key tanımlanması için
        public int Stok { get; set; }
        public int Raf { get; set; }
        public int Ambar { get; set; }



    }
}
