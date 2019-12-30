using CfErpApp.Fonksiyonlar;
using CfErpApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CfErpApp.BilgiGiris
{
    public partial class frmUrunGiris : Form
    {   
        //1.Yapılacaklar
        CfErpContext db = new CfErpContext();
        Numaralar N = new Numaralar();
        int secimId = -1;
        bool edit = false;
        public frmUrunGiris()
        {
            InitializeComponent();
        }

        private void frmUrunGiris_Load(object sender, EventArgs e)  //2. Yapılacaklar
        {   
                        Combo();
            Listele();  //5.1.
        }

        private void Combo()
        {
            //3.Yapılacaklar
            txtCari.DataSource = db.tblCaris.ToList();
            txtCari.ValueMember = "Id";
            txtCari.DisplayMember = "CariAdi";  // Datanase'de tblCaris'teki CariAdi yazımı ila aynı olacak
            //Görünen kısımda Cari adını yazacak ancak kaydederken id'sini kaydetecek
            txtCari.SelectedIndex = -1; //İlk açılışta combobox boş gelsin

            txtKategori.DataSource = db.kategoris.ToList(); //cferpcontext'deki tablo ismi
            txtKategori.ValueMember = "Id";
            txtKategori.DisplayMember = "KategoriAdi";
            //Görünen kısımda Cari adını yazacak ancak kaydederken id'sini kaydetecek
            txtKategori.SelectedIndex = 0; //İlk açılışta combobox boş gelsin

            txtMensei.DataSource = db.menseis.ToList();
            txtMensei.ValueMember = "Id";
            txtMensei.DisplayMember = "MenseiAdi";
            //Görünen kısımda Cari adını yazacak ancak kaydederken id'sini kaydetecek
            txtMensei.SelectedIndex = 0; //İlk açılışta combobox boş gelsin

            txtBirim.SelectedIndex = 0;
            
            //Server'da Kategori ve Mensei tabloalrına elle bilgi girişi yapacağız.

        }

        void YeniKaydet()   //4.Yapılacaklar textbox,comboboxtaki verileri nesneye yükle
        {
            try
            {
                var dbKontrol = (from s in db.tblUrunler
                                 where s.UrunKodu == txtUrunKodu.Text
                                 select s).ToList();
                if (dbKontrol.Count == 0)   //Tek bir ürün kodunda ürün girilsin
                {
                    tblUrunler urun = new tblUrunler(); //ürünler tablosundaki tüm attribute'ları ürün nesnesinin içine attık
                    urun.Aciklama = txtAciklama.Text;
                    urun.BirimTipi = txtBirim.Text; //bu bir combobox ama stringleri taşımak istiyoruz
                    urun.GirisTarih = Convert.ToDateTime(txtGirisTarihi.Text);
                    urun.KategoriId = db.kategoris.First(x => x.KategoriAdi == txtKategori.Text).Id; //find'da id belirtebiliyoruz first'te koşul getirebiliriyoruz
                                                                                                     //KategoriAdi, txtKategori'ye eşitse Id'sini getir
                    urun.MenseiId = db.menseis.First(x => x.MenseiAdi == txtMensei.Text).Id;
                    urun.TblCariId = db.tblCaris.First(x => x.CariAdi == txtCari.Text).Id;
                    urun.UrunAdi = txtUrunAdi.Text;
                    urun.UrunKodu = txtUrunKodu.Text;
                    db.tblUrunler.Add(urun); //Bu yaptığımız değişikleri tabloya eklememiz lazım.
                    db.SaveChanges();   //değişiklikleri kaydet
                    MessageBox.Show("Kayıt Oluşturuldu");

                    tblStokDurum stk = new tblStokDurum();
                    stk.Ambar = 0;
                    stk.Barkod = txtUrunKodu.Text + '/' + txtUrunAdi.Text;
                    stk.Raf = 0;
                    stk.Stok = 0;
                    stk.StokKodu = N.stokNo();
                    stk.UrunId = db.tblUrunler.First(x => x.UrunKodu.ToLower() == txtUrunKodu.Text.ToLower()).Id;
                    db.tblStokDurums.Add(stk);
                    db.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Bu Ürün Kodu Kullanılmış Lütfen Kontrol Edin");
                    return; //Metodu sonlandırır. Çalışmaya geri dönder.
                }

                Temizle();
                Listele();
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata : Urunler Yeni Kaydet Hatası/n"+e);
            }
        }

        private void Listele()  //6.Yapılacaklar
        {
            Liste.Rows.Clear();
            int i = 0;
            var srg = (from s in db.tblUrunler
                       where s.UrunKodu.Contains(txtBul.Text) || s.UrunAdi.Contains(txtBul.Text)    //13.1
                       select s).ToList(); //database'deki sorguyu çekmemiz lazım
            foreach (var k in srg)
            {
                Liste.Rows.Add();   //herbir satırı kendisinden önce oluşturmalı 
                Liste.Rows[i].Cells[0].Value = k.Id;
                Liste.Rows[i].Cells[1].Value = k.UrunKodu;
                Liste.Rows[i].Cells[2].Value = k.UrunAdi;
                Liste.Rows[i].Cells[3].Value = k.Kategori.KategoriAdi;  //Kategori numerik olduğu için Kategori sınıfının KategoriAdi'ni alırız
                Liste.Rows[i].Cells[4].Value = k.Mensei.MenseiAdi;
                i++;
            }
            Liste.AllowUserToAddRows = false;
            btnKaydet.Text = "Kaydet";
        }

        private void Temizle()  //5.Yapılacaklar
        {
            foreach (Control cont in split2.Panel1.Controls) //Control bir sınıf kontrol sınıfından bir nesne üretmemiz lazım
            {
                if (cont is TextBox || cont is ComboBox || cont is DateTimePicker)
                {
                    cont.Text = "";
                }
            }
            //12.Yapılacaklar. Değişkenleri default'a Çevireceğiz
            secimId = -1;
            edit = false;
        }

        private void btnKaydet_Click(object sender, EventArgs e)    //11.Yapılacaklar
        {
            if (edit && secimId > 0 && MessageBox.Show("Kaydı Güncellemek İstiyor Musunuz?", "Güncelleme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Guncelle();
            else if (edit == false)
                YeniKaydet();
        }

        private void Guncelle() //7.Yapılacaklar
        {
            tblUrunler urun =db.tblUrunler.First(x => x.Id == secimId); //ürünler tablosundaki tüm attribute'ları ürün nesnesinin içine attık
            urun.Aciklama = txtAciklama.Text;
            urun.BirimTipi = txtBirim.Text; //bu bir combobox ama stringleri taşımak istiyoruz
            urun.GirisTarih = Convert.ToDateTime(txtGirisTarihi.Text);
            urun.KategoriId = db.kategoris.First(x => x.KategoriAdi == txtKategori.Text).Id; //find'da id belirtebiliyoruz first'te koşul getirebiliriyoruz
                                                                                             //KategoriAdi, txtKategori'ye eşitse Id'sini getir
            urun.MenseiId = db.menseis.First(x => x.MenseiAdi == txtMensei.Text).Id;
            urun.TblCariId = db.tblCaris.First(x => x.CariAdi == txtCari.Text).Id;
            urun.UrunAdi = txtUrunAdi.Text;
            urun.UrunKodu = txtUrunKodu.Text;
            
            db.SaveChanges();   //değişiklikleri kaydet
            MessageBox.Show("Kayıt Güncellendi");
            Temizle();
            Listele();
        }

        private void Ac(int id) //10.Yapılacaklar
        {
            Temizle();
            edit = true;
            secimId = id;
            tblUrunler urun = db.tblUrunler.Find(id);   // var urun = db.tblUrunler.Find(id) //şekl tazıp var nesnesinden de üretebiliriz Resharper için uygun olur
            txtAciklama.Text = urun.Aciklama;
            txtBirim.Text = urun.BirimTipi;
            txtCari.Text = urun.TblCari.CariAdi;
            txtGirisTarihi.Text =urun.GirisTarih.ToShortDateString();
            txtKategori.Text = urun.Kategori.KategoriAdi;
            txtMensei.Text = urun.Mensei.MenseiAdi;
            txtUrunAdi.Text = urun.UrunAdi;
            txtUrunKodu.Text = urun.UrunKodu;

            btnKaydet.Text = "Güncelle";
        }

        private void Liste_DoubleClick(object sender, EventArgs e)  //8  - 10.1.
        {
            Sec(); 

            if (secimId>0)
            {
                Ac(secimId);
            }
        }

        private void Sec()  //9.Yapılacaklar
        {
            try
            {
                secimId = int.Parse(Liste.CurrentRow.Cells[0].Value.ToString());    //çift tıkladığımız satırdaki Id'yi al secim id'ye ata
                //secimId = Convert.ToInt32(Liste.CurrentRow.Cells[0].Value.ToString());  //şeklinde de yazılabilir.
            }
            catch (Exception)
            {
                secimId = -1;
            }
        }

        private void btnBul_Click(object sender, EventArgs e)   //13
        {
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)   //14
        {
            db.tblUrunler.Remove(db.tblUrunler.Find(secimId));
            db.SaveChanges();
            MessageBox.Show("Kayıt Silinmiştir");
            Temizle();
            Listele();
        }
    }
}
