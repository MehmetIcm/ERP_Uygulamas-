using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CfErpApp.Model
{
    public class tblUrunler:BaseEntity
    {
        [StringLength(50)]
        public string UrunKodu { get; set; }
        [StringLength(250)]
        public string UrunAdi { get; set; }
        public int KategoriId { get; set; }
        public virtual Kategori Kategori { get; set; }
        [DataType(DataType.Date)]
        public DateTime GirisTarih { get; set; }
        [StringLength(500)]
        public string Aciklama { get; set; }
        [StringLength(20)]
        public string BirimTipi { get; set; }
        public int TblCariId { get; set; }
        public virtual tblCari TblCari { get; set; }
        public int MenseiId { get; set; }
        public virtual Mensei Mensei { get; set; }
    }
    public class Kategori : BaseEntity
    {
        [StringLength(50)]
        public string KategoriAdi { get; set; }
    }
    public class Mensei : BaseEntity
    {
        [StringLength(50)]
        public string MenseiAdi { get; set; }
    }
}
