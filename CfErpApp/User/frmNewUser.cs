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

namespace CfErpApp.User
{
    public partial class frmNewUser : Form
    {
        CfErpContext db = new CfErpContext();

        bool edit = false;
        public int secimId = -1;
        public bool Secim = false;

        public frmNewUser()
        {
            InitializeComponent();
        }

        private void frmNewUser_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            Liste.Rows.Clear();
            var srg = (from s in db.tblUsers
                       where s.UserName.Contains(txtBul.Text)       //contains, kesinlik ifadesi katar texti içerirse getirir, boşsa herşeyi getirir 
                       select s).ToList();
            int i = 0;
            foreach (var k in srg)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.Id;
                Liste.Rows[i].Cells[1].Value = k.UserName;
                Liste.Rows[i].Cells[2].Value = k.Sifre;
                Liste.Rows[i].Cells[3].Value = k.Role;
                i++;
            }
            Liste.AllowUserToAddRows = false;
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
            tblUsers user = db.tblUsers.First(x => x.Id == secimId);

            user.UserName = txtKulAdi.Text;
            user.Sifre = txtSifre.Text;
            user.Role = Convert.ToInt32(txtRol.SelectedIndex.ToString());

            db.SaveChanges();
            MessageBox.Show("Güncelleme Yapıldı");
            Listele();
            Temizle();
        }

        private void YeniKayit()
        {
            try
            {
                var dbKontrol = (from s in db.tblUsers
                                 where s.UserName == txtKulAdi.Text
                                 select s).ToList();

                if (dbKontrol.Count == 0)
                {
                    tblUsers user = new tblUsers();

                    user.UserName = txtKulAdi.Text;
                    user.Sifre = txtSifre.Text;
                    user.Role = Convert.ToInt32(txtRol.SelectedIndex.ToString());

                    db.tblUsers.Add(user);
                    db.SaveChanges();
                    MessageBox.Show("Kayıt Eklendi");
                }
                else
                {
                    MessageBox.Show("Bu Kullanıcı Adı Alınmış Lütfen Yeni Bir Kullanıcı Adı Girin");
                    return; //Metodu sonlandırır. Çalışmaya geri dönder.
                }
                Listele();
                Temizle();
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata : Users Yeni Kaydet Hatası/n" + e);
            }
        }

        private void Temizle()
        {
            foreach (Control ct in split2.Panel1.Controls)
            {
                if (ct is TextBox || ct is ComboBox)
                {
                    ct.Text = "";
                }
            }
            edit = false;
            secimId = -1;
            btnKaydet.Text = "Kaydet";
        }
        private void Ac(int id)
        {
            Temizle();
            edit = true;
            secimId = id;
            tblUsers user = db.tblUsers.Find(id);
            txtKulAdi.Text = user.UserName;
            txtSifre.Text = user.Sifre;
            for (int i = 0; i < txtRol.Items.Count; i++)
            {
                if (user.Role==i)
                {
                    txtRol.SelectedIndex = i;
                }
            }
            //txtRol.Text = Convert.ToString(user.Role);

            btnKaydet.Text = "Güncelle";
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
            };
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtKulAdi.Text!="" && secimId!=-1)
            {
                db.tblUsers.Remove(db.tblUsers.Find(secimId));
                db.SaveChanges();
                MessageBox.Show("Silme İşlemi Başarılı");
                Temizle();
                Listele(); 
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            Listele();      //where s.UserName.Contains(txtBul.Text)  //Listele() yazdıktan sonra listeleye bunu yazmalıyız
        }

        private void txtBul_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBul_Click(this, new EventArgs());
            }
        }
    }
}
