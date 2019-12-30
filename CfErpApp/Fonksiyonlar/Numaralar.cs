using CfErpApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CfErpApp.Fonksiyonlar
{
    public class Numaralar
    {
        CfErpContext db = new CfErpContext();
        public string persNo()
        {
            try
            {
                double numara = double.Parse((from s in db.Personels orderby s.Id descending select s).First().PersonelNo);
                numara++;
                string num = numara.ToString().PadLeft(7, '0');
                return num;
            }
            catch (Exception)
            {
                return"0000001";
            }
        }
        public string cariNo()
        {
            try
            {
                double numara = double.Parse((from s in db.tblCaris orderby s.Id descending select s).First().CariNo);
                numara++;
                string num = numara.ToString().PadLeft(7, '0');
                return num;
            }
            catch (Exception)
            {
                return "0000001";
            }
       
        }
        public string urunAlisNo()
        {
            try
            {
                double numara = double.Parse((from s in db.tblUrunAlis orderby s.Id descending select s).First().UrunAlisNo);
                numara++;
                string num = numara.ToString().PadLeft(7, '0');
                return num;
            }
            catch (Exception)
            {
                return "0000001";
            }
        }
        public string urunSatisNo()
        {
            try
            {
                double numara = double.Parse((from s in db.tblUrunSatis orderby s.Id descending select s).First().UrunSatisNo);
                numara++;
                string num = numara.ToString().PadLeft(7, '0');
                return num;
            }
            catch (Exception)
            {
                return "0000001";
            }
        }
        public int stokNo()
        {
            try
            {
                double numara =(from s in db.tblStokDurums orderby s.Id descending select s).First().StokKodu;
                numara++;
                int num = Convert.ToInt32(numara);
                return num;
            }
            catch (Exception)
            {
                return 1;
            }
        }
    }
}
