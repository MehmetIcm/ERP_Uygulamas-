using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CfErpApp.Model
{
    public class Personel
    {
        public int Id { get; set; }
        [StringLength(7)]
        public string PersonelNo { get; set; }
        [StringLength(100)]
        public string Ad { get; set; }
        [StringLength(20)]
        public string Tel { get; set; }
        [StringLength(20)]
        public string Gsm { get; set; }
        public string Adres { get; set; }
        [DataType(DataType.Date)]   //saat ve dakika istemiyorsak, sadece date'ini alırız
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime IsBasiTarih { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime IsSonTarih { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DogumTarih { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        [StringLength(20)]
        public string TcNo { get; set; }
        [StringLength(20)]
        public string Yetki { get; set; }
        public bool CinsiyetId { get; set; }
        public bool MedeniHal { get; set; }

        public int? DepartmanId { get; set; }
        public virtual Departman Departman { get; set; }
        public int? UnvanId { get; set; }   //? -> null gelmesine izin veriyoruz
        //[ForeignKey("UnvanId")]
        public virtual Unvan Unvan { get; set; }

        [Column (TypeName ="image")]    //column'un altını çizer  using System.ComponentModel.DataAnnotations.Schema;
        public byte[] Foto { get; set; }

    }
}
