using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CfErpApp.Model
{
    public class Departman:BaseEntity   //Tablomuzun ihtiyacı olan Id field'ını BaseEntity isimli oluşturduğumuz classtan miras(Inheritance) alırız.
    {
        public string DepartanAdi { get; set; }

        //public virtual ICollection<Personel> Personels { get; set; }
    }
}
