using CfErpApp.Fonksiyonlar;
using CfErpApp.Model;
using CfErpApp.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq; //Resim verisi üzerinde işlem yapmamız için binary sınınıfına ulaşmamız gerekiyor
using System.Drawing;
using System.Linq;  //sistem linqsu yaptığımız db sorguları
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CfErpApp.BilgiGiris
{
    public partial class frmPersonelGiris : Form
    {
        CfErpContext db = new CfErpContext();
        Numaralar N = new Numaralar();
        Resimler R = new Resimler();

        public int secimId=-1;
        OpenFileDialog _diaolog = new OpenFileDialog();
        bool _resim = false;
        bool edit = false;

        public frmPersonelGiris()
        {
            InitializeComponent();
        }

        private void frmPersonelGiris_Load(object sender, EventArgs e)
        {
            txtPersonelNo.Text = N.persNo();
            Listele();
            ComboDoldur();
            
        }

        private void ComboDoldur()
        {
            txtDepartman.DataSource = db.Departmen.ToList();
            txtDepartman.ValueMember = "Id";
            txtDepartman.DisplayMember = "DepartanAdi";

            txtUnvan.DataSource = db.Unvans.ToList();
            txtUnvan.ValueMember = "Id";
            txtUnvan.DisplayMember = "UnvanAdi";
        }

        void YeniKaydet()
        {
            Personel personel = new Personel();
            personel.Ad = txtAd.Text;
            personel.Adres = txtAdres.Text;
            //if(txtCinsiyet.Text=="Kadın")
            //{
            //    personel.CinsiyetId = true;
            //}
            //else 
            //{
            //    personel.CinsiyetId = false;
            //}
            personel.CinsiyetId = txtCinsiyet.Text == "Kadın" ? personel.CinsiyetId = true : false;     //yukarıdaki if'in kısalaştırılmış hali
            personel.DepartmanId = db.Departmen.First(x => x.DepartanAdi == txtDepartman.Text).Id;
            personel.DogumTarih = DateTime.Parse(txtDogumTarih.Text);
            personel.Email = txtEmail.Text;
            personel.Gsm = txtGsm.Text;
            personel.IsBasiTarih= DateTime.Parse(txtIsBasTarih.Text);
            personel.IsSonTarih= DateTime.Parse(txtIsSonTarih.Text);
            personel.MedeniHal = txtMedeni.Text == "Evli" ? personel.MedeniHal = true : false;
            personel.PersonelNo = txtPersonelNo.Text;
            personel.TcNo = txtTc.Text;
            personel.Tel = txtTel.Text;
            personel.UnvanId = db.Unvans.First(x => x.UnvanAdi == txtUnvan.Text).Id;
            personel.Yetki = txtYetkili.Text;
            personel.Foto = new Binary(R.ResimYukleme(txtResim.Image)).ToArray();

            db.Personels.Add(personel);
            db.SaveChanges();
            MessageBox.Show("Kayıt Eklendi");
            Listele();
            Temizle();

        }

        void Guncelle()
        {
            Personel personel = db.Personels.First(x => x.Id == secimId);
            personel.Ad = txtAd.Text;
            personel.Adres = txtAdres.Text;
            personel.CinsiyetId = txtCinsiyet.Text == "Kadın" ? personel.CinsiyetId = true : false;     //yukarıdaki if'in kısalaştırılmış hali
            personel.DepartmanId = db.Departmen.First(x => x.DepartanAdi == txtDepartman.Text).Id;
            personel.DogumTarih = DateTime.Parse(txtDogumTarih.Text);
            personel.Email = txtEmail.Text;
            personel.Gsm = txtGsm.Text;
            personel.IsBasiTarih = DateTime.Parse(txtIsBasTarih.Text);
            personel.IsSonTarih = DateTime.Parse(txtIsSonTarih.Text);
            personel.MedeniHal = txtMedeni.Text == "Evli" ? personel.MedeniHal = true : false;
            personel.TcNo = txtTc.Text;
            personel.Tel = txtTel.Text;
            personel.UnvanId = db.Unvans.First(x => x.UnvanAdi == txtUnvan.Text).Id;
            personel.Yetki = txtYetkili.Text;
            if (_resim) //if(_resim == true) ile aynı şey
            {
                personel.Foto = new Binary(R.ResimYukleme(txtResim.Image)).ToArray();
            }
            
            db.SaveChanges();
            MessageBox.Show("Güncelleme Yapıldı");
            Listele();
            Temizle();
        }

        private void Temizle()
        {
            foreach(Control cont in split2.Panel1.Controls)
            {
                if(cont is TextBox || cont is ComboBox)
                {
                    cont.Text = "";
                }
            }
            txtDogumTarih.Text = DateTime.Now.ToShortDateString();
            txtIsBasTarih.Text = DateTime.Now.ToShortDateString();
            txtIsSonTarih.Text = DateTime.Now.ToShortDateString();
            txtPersonelNo.Text = N.persNo();
            txtResim.Image = Resources.resimyok;
            edit = false;
            _resim = false;
            btnKaydet.Text = "Kaydet";
        }

        private void Listele()
        {
            Liste.Rows.Clear();
            int i = 0;
            var srg = (from s in db.Personels select s).ToList();
            foreach(var k in srg)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.Id;
                Liste.Rows[i].Cells[1].Value = k.PersonelNo;
                Liste.Rows[i].Cells[2].Value = k.Ad;
                Liste.Rows[i].Cells[3].Value = k.Unvan.UnvanAdi;
                Liste.Rows[i].Cells[4].Value = k.Departman.DepartanAdi;
                Liste.Rows[i].Cells[5].Value = k.Tel;
                Liste.Rows[i].Cells[6].Value = k.Gsm;
                i++;
            }
            Liste.AllowUserToAddRows = false;   //son satırda fazladan ekliyor onu kaldırmak için ekliyoruz
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (edit && secimId > 0 && MessageBox.Show("Kaydı Güncellemek İstiyor Musunuz?", "Güncelleme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Guncelle();
            else if (edit==false)
                YeniKaydet();
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if (secimId>0)
            {
                Ac(secimId);
            }
        }

        private void Ac(int id)
        {
            Temizle();
            edit = true;
            
            Personel pers = db.Personels.Find(id);  //database'e o id'ye bağlı olan tüm bilgileri pers nesnesine at
            txtAd.Text = pers.Ad;
            txtAdres.Text = pers.Adres;
            txtCinsiyet.Text = pers.CinsiyetId==true?txtCinsiyet.Text="Kadın":txtCinsiyet.Text="Erkek";
            txtDepartman.Text = pers.Departman.DepartanAdi;
            txtDogumTarih.Text = pers.DogumTarih.ToShortDateString();
            txtEmail.Text = pers.Email;
            txtGsm.Text = pers.Gsm;
            txtIsBasTarih.Text = pers.IsBasiTarih.ToShortDateString();
            txtIsSonTarih.Text = pers.IsSonTarih.ToShortDateString();
            txtMedeni.Text = pers.MedeniHal == true ? txtMedeni.Text = "Evli":txtMedeni.Text = "Bekar";
            txtPersonelNo.Text = pers.PersonelNo;
            txtTc.Text = pers.TcNo; 
            txtUnvan.Text=pers.Unvan.UnvanAdi;
            txtYetkili.Text = pers.Yetki;
            if(pers.Foto!=null) txtResim.Image = R.ResimGetirme(pers.Foto.ToArray());
            btnKaydet.Text = "Güncelle";
            
        }

        private void Sec()
        {
            try
            {
                secimId = int.Parse(Liste.CurrentRow.Cells[0].Value.ToString());    //çift tıkladığımız satırdaki Id'yi al secim id'ye ata
            }
            catch (Exception)
            {
                secimId = -1;
            }
        }

        private void btnResimSec_Click(object sender, EventArgs e)
        {
            ResimSec();
        }

        private void ResimSec()
        {
            _diaolog.Filter = "Jpg(*.jpg)|*.jpg|Jpeg(*.jpeg)|*.jpeg";   //jpegle ilgili tüm gelen formatları kabul et
            if (_diaolog.ShowDialog() == DialogResult.OK)
            {
                txtResim.ImageLocation = _diaolog.FileName;
                _resim = true;
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
