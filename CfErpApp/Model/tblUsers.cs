using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CfErpApp.Model
{
    public class tblUsers : BaseEntity  //BaseEnetity Id'yi baseden alsın
    {
        public string UserName { get; set; }
        public string Sifre { get; set; }
        public int Role { get; set; }
    }
}
