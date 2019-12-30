using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;    //stringlength için
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CfErpApp.Model
{
    public class tblCari:BaseEntity
    {
        [StringLength(7)]
        public string CariNo  { get; set; }

        [StringLength(50)]
        public string CariAdi { get; set; }
        public int? CariTurId { get; set; }    //forein key bağlantısı için ?
        public virtual tblCariTur CariTur { get; set; }  //tblCariTur class'ı ile CariTuruId'yi paylaş (bir yukarıdaki)
        public string VergiDairesi { get; set; }

        [StringLength(20)]
        public string VergiNo { get; set; }

        public string Adres { get; set; }

        [StringLength(50)]
        public string Yetkili { get; set; }

        [StringLength(20)]
        public string Tel { get; set; }

        [StringLength(20)]
        public string Gsm { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Web { get; set; }

    }
    public class tblCariTur:BaseEntity
    {
        public string CariTurAdi { get; set; }
    }
}
