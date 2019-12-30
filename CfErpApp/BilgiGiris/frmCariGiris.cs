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
    public partial class frmCariGiris : Form
    {
        CfErpContext db = new CfErpContext();
        Numaralar N = new Numaralar();

        bool edit = false;
        public int secimId = -1;
        public frmCariGiris()
        {
            InitializeComponent();
        }

        private void frmCariGiris_Load(object sender, EventArgs e)
        {
            txtCariNo.Text = N.cariNo();
            Combo();
            Listele();
        }

        private void Listele()
        {
            Liste.Rows.Clear();
            var srg = (from s in db.tblCaris
                       select s).ToList();
            int i = 0;
            foreach (var k in srg)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.Id;
                Liste.Rows[i].Cells[1].Value = k.CariNo;
                Liste.Rows[i].Cells[2].Value = k.CariAdi;
                Liste.Rows[i].Cells[3].Value = k.Yetkili;
                Liste.Rows[i].Cells[4].Value = k.Tel;
                Liste.Rows[i].Cells[5].Value = k.Gsm;
                i++;
            }
            Liste.AllowUserToAddRows = false;
        }
        void Temizle()
        {
            foreach(Control ct in split2.Panel1.Controls)
            {
                if(ct is TextBox || ct is ComboBox)
                {
                    ct.Text = "";
                }
            }
            edit = false;
            secimId = -1;
        }
        private void Combo()
        {
            txtCariTur.DataSource = db.tblCariTurs.ToList();
            txtCariTur.ValueMember = "Id";
            txtCariTur.DisplayMember = "CariTurAdi";

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (edit && secimId > 0 && MessageBox.Show("Kaydı Güncellemek İstiyor Musunuz?", "Güncelleme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Guncelle();
            else if (edit == false)
                YeniKayit();
        }

        private void Guncelle()
        {
            tblCari cari = db.tblCaris.First(x => x.Id == secimId);
            cari.Adres = txtAdres.Text;
            cari.CariAdi = txtCariAdi.Text;
            cari.CariNo = txtCariNo.Text;
            cari.CariTurId = db.tblCariTurs.First(x => x.CariTurAdi == txtCariTur.Text).Id;
            cari.Email = txtEmail.Text;
            cari.Gsm = txtGsm.Text;
            cari.Tel = txtTel.Text;
            cari.VergiDairesi = txtVergiDairesi.Text;
            cari.VergiNo = txtVn.Text;
            cari.Web = txtWeb.Text;
            cari.Yetkili = txtYetkili.Text;

            db.SaveChanges();
            MessageBox.Show("Güncelleme Yapıldı");
            Listele();
            Temizle();
        }

        private void Ac(int id)
        {
            Temizle();
            edit = true;
            secimId = id;
            tblCari cari = db.tblCaris.Find(id);
            txtAdres.Text = cari.Adres;
            txtCariAdi.Text = cari.CariAdi;
            txtCariNo.Text = cari.CariNo;
            txtCariTur.Text = cari.CariTur.CariTurAdi;
            txtEmail.Text = cari.Email;
            txtGsm.Text = cari.Gsm;
            txtTel.Text = cari.Tel;
            txtVergiDairesi.Text = cari.VergiDairesi;
            txtVn.Text = cari.VergiNo;
            txtWeb.Text = cari.Web;
            txtYetkili.Text = cari.Yetkili;

            btnKaydet.Text = "Güncelle";
        }

        private void YeniKayit()
        {
            tblCari cari = new tblCari();
            
            cari.Adres = txtAdres.Text;
            cari.CariAdi = txtCariAdi.Text;
            cari.CariNo = txtCariNo.Text;
            cari.CariTurId = db.tblCariTurs.First(x => x.CariTurAdi == txtCariTur.Text).Id;
            cari.Email = txtEmail.Text;
            cari.Gsm = txtGsm.Text;
            cari.Tel = txtTel.Text;
            cari.VergiDairesi = txtVergiDairesi.Text;
            cari.VergiNo = txtVn.Text;
            cari.Web = txtWeb.Text;
            cari.Yetkili = txtYetkili.Text;

            db.tblCaris.Add(cari);
            db.SaveChanges();
            MessageBox.Show("Kayıt Eklendi");
            Listele();
            Temizle();
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if (secimId > 0)
            {
                Ac(secimId);
            }
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
    }
}
