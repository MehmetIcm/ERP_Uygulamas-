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

namespace CfErpApp.Urun
{
    public partial class frmUrunSatis : Form
    {
        #region Sabitler
        CfErpContext db = new CfErpContext();
        Numaralar N = new Numaralar();
        Formlar F = new Formlar();
        bool edit = false;
        public int secimId = -1;
        int urunSatisId = -1;
        public string[] MyArray { get; set; }
        #endregion
        public frmUrunSatis()
        {
            InitializeComponent();
        }
        private void frmUrunSatis_Load(object sender, EventArgs e)
        {
            txtUrunSatisNo.Text = N.urunSatisNo();
            Combo();
        }
        private void Combo()
        {
            txtCari.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection veri = new AutoCompleteStringCollection();
            txtCari.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            var lst = db.tblCaris.Select(x => x.CariAdi).Distinct();
            foreach (string cari in lst)
            {
                veri.Add(cari);
                txtCari.Items.Add(cari);
            }
            txtCari.AutoCompleteCustomSource = veri;
            //combobox'ın propeeties'inden autocompletemode=suggest append yapmalıyız

            ukod.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection veri1 = new AutoCompleteStringCollection();
            ukod.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            var lst1 = db.tblUrunler.Select(x => x.UrunKodu).Distinct();
            foreach (string u in lst1)
            {
                veri1.Add(u);
                ukod.Items.Add(u);
            }
            ukod.AutoCompleteCustomSource = veri1;

            int dgv;
            dgv = ukod.Items.Count; //ukod içerisindeki item (ürün) sayısını say
            MyArray = new string[dgv];
            for (int x = 0; x < dgv; x++)
            {
                MyArray[x] = ukod.Items[x].ToString();
            }


            txtPersonel.DataSource = db.Personels.ToList();
            txtPersonel.DisplayMember = "Ad";
            txtPersonel.ValueMember = "Id";
            txtPersonel.SelectedIndex = -1;
        }
        void Temizle()
        {

            foreach (Control cont in split2.Panel1.Controls)
            {
                if (cont is TextBox || cont is ComboBox || cont is DateTimePicker)
                {
                    cont.Text = "";
                }
                Liste.Rows.Clear();
            }
            txtUrunSatisNo.Text = N.urunAlisNo();
            secimId = -1;
            edit = false;
            urunSatisId = -1;
            Liste.AllowUserToAddRows = true;
        }
        void YeniKaydet()
        {
            tblUrunSatis[] ual = new tblUrunSatis[Liste.RowCount]; //Satır sayısı kadar arrayimi oluştur
            Liste.AllowUserToAddRows = false;
            for (int i = 0; i < Liste.RowCount; i++)
            {
                ual[i] = new tblUrunSatis();
                ual[i].SatisTarih = Convert.ToDateTime(txtSatisTarih.Text);
                ual[i].AraToplam = Convert.ToDecimal(txtAraToplam.Text);
                ual[i].SFiyat = Convert.ToDecimal(Liste.Rows[i].Cells[2].Value);
                ual[i].KdvToplam = Convert.ToDecimal(txtKdvToplam.Text);
                ual[i].KdvTutar = Convert.ToDecimal(Liste.Rows[i].Cells[5].Value);
                ual[i].Miktar = Convert.ToInt32(Liste.Rows[i].Cells[3].Value);
                ual[i].PersonelId = db.Personels.First(x => x.Ad == txtPersonel.Text).Id;
                ual[i].TblCariId = db.tblCaris.First(x => x.CariAdi == txtCari.Text).Id;
                string temp = Liste.Rows[i].Cells[0].Value.ToString();
                ual[i].TblUrunId = db.tblUrunler.First(x => x.UrunKodu == temp).Id;
                ual[i].TutarToplam = Convert.ToDecimal(txtToplamTutar.Text);
                ual[i].UrunSatisNo = txtUrunSatisNo.Text;
                ual[i].KarOran = Convert.ToDecimal(txtKarOran.Text);
                ual[i].Aktif = false;

                db.tblUrunSatis.Add(ual[i]);
                string birlestir = Liste.Rows[i].Cells[0].Value.ToString() + "/" + Liste.Rows[i].Cells[1].Value.ToString();
                var stokKontrol = (from s in db.tblStokDurums
                                   where s.Barkod == birlestir
                                   select s).ToList();
                if (stokKontrol.Count > 0)
                {
                    tblStokDurum stk = db.tblStokDurums.First(x => x.Barkod == birlestir);
                    stk.Stok -= Convert.ToInt32(Liste.Rows[i].Cells[3].Value);
                    stk.Raf -= Convert.ToInt32(Liste.Rows[i].Cells[3].Value);
                }
            }
            db.SaveChanges();
            MessageBox.Show("Kayıt Eklendi");
            Temizle();
        }
        void Guncelle()
        {
            string uano = urunSatisId.ToString().PadLeft(7, '0');
            tblUrunSatis[] ual = new tblUrunSatis[Liste.RowCount]; //Satır sayısı kadar arrayimi oluştur
            for (int i = 0; i < Liste.RowCount; i++)
            {
                int idAl = Convert.ToInt32(Liste.Rows[i].Cells[6].Value);
                ual[i] = db.tblUrunSatis.Where(x => x.UrunSatisNo == uano && x.Id == idAl).FirstOrDefault();
                ual[i].SatisTarih = Convert.ToDateTime(txtSatisTarih.Text);
                ual[i].AraToplam = Convert.ToDecimal(txtAraToplam.Text);
                ual[i].SFiyat = Convert.ToDecimal(Liste.Rows[i].Cells[2].Value);
                ual[i].KdvToplam = Convert.ToDecimal(txtKdvToplam.Text);
                ual[i].KdvTutar = Convert.ToDecimal(Liste.Rows[i].Cells[5].Value);
                ual[i].Miktar = Convert.ToInt32(Liste.Rows[i].Cells[3].Value);
                ual[i].PersonelId = db.Personels.First(x => x.Ad == txtPersonel.Text).Id;
                ual[i].TblCariId = db.tblCaris.First(x => x.CariAdi == txtCari.Text).Id;
                string temp = Liste.Rows[i].Cells[0].Value.ToString();
                ual[i].TblUrunId = db.tblUrunler.First(x => x.UrunKodu == temp).Id;
                ual[i].TutarToplam = Convert.ToDecimal(txtToplamTutar.Text);
                ual[i].UrunSatisNo = txtUrunSatisNo.Text;
                ual[i].KarOran = Convert.ToDecimal(txtKarOran.Text);
                ual[i].Aktif = false;
                
            }
            db.SaveChanges();
            MessageBox.Show("Kayıt Güncellendi");
            Temizle();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (edit && urunSatisId > 0) Guncelle();
            else if (edit == false) YeniKaydet();
        }
        private void Liste_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            try
            {
                TextBox txt = e.Control as TextBox;     //txt isimli bir nesne oluşturduk. Özelliği datagridview içerisindeki textbox control alanından gelsin
                if (Liste.CurrentCell.ColumnIndex == 0 && txt != null)
                {
                    txt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    txt.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    txt.AutoCompleteCustomSource.AddRange(MyArray);   //Addrange ile add'den farklı olarak bir arrayin tüm verilerini ekleyebiliriz
                }
                else if (Liste.CurrentCell.ColumnIndex != 0 && txt != null)
                {
                    txt.AutoCompleteMode = AutoCompleteMode.None;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        protected override void OnLoad(EventArgs e) //sanal buton oluşturma önce bu iki kod yazılır sonra formlarda UrunAlisListesi() metodu oluşturulup çağrılır
        {
            var btnSatis = new Button();
            btnSatis.Size = new Size(25, txtUrunSatisNo.ClientSize.Height + 2);
            btnSatis.Location = new Point(txtUrunSatisNo.ClientSize.Width - btnSatis.Width, -1);
            btnSatis.Cursor = Cursors.Default;
            txtUrunSatisNo.Controls.Add(btnSatis);
            base.OnLoad(e);
            btnSatis.Click += btnSatis_Click;
        }

        private void btnSatis_Click(object sender, EventArgs e)
        {
            int id = F.UrunSatisListesi(true);
            urunSatisId = id;
            if (id > 0)
            {
                Ac(id);
            }
            frmAnaSayfa.AktarmaInt = -1;
        }
        private void Ac(int id)
        {
            Liste.Rows.Clear();
            int i = 0;
            edit = true;
            string temp = id.ToString().PadLeft(7, '0');
            tblUrunSatis ust = db.tblUrunSatis.First(x => x.UrunSatisNo == temp);
            txtUrunSatisNo.Text = ust.SatisTarih.ToShortDateString();
            txtAraToplam.Text = ust.AraToplam.ToString();
            txtCari.Text = ust.TblCari.CariAdi;
            txtKdvToplam.Text = ust.KdvToplam.ToString();
            txtPersonel.Text = ust.Personel.Ad;
            txtToplamTutar.Text = ust.TutarToplam.ToString();
            txtUrunSatisNo.Text = ust.UrunSatisNo;
            txtKarOran.Text = ust.KarOran.ToString();

            var srg = (from s in db.tblUrunSatis
                       where s.UrunSatisNo == temp
                       select s).ToList();
            foreach (tblUrunSatis k in srg)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.TblUrun.UrunKodu;
                Liste.Rows[i].Cells[1].Value = k.TblUrun.UrunAdi;
                Liste.Rows[i].Cells[2].Value = k.SFiyat;
                Liste.Rows[i].Cells[3].Value = k.Miktar;
                Liste.Rows[i].Cells[4].Value = k.TblUrun.BirimTipi;
                Liste.Rows[i].Cells[5].Value = k.KdvTutar;
                Liste.Rows[i].Cells[6].Value = k.Id;
                i++;
            }
            Liste.AllowUserToAddRows = false;
        }
        private void Liste_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0)
                {
                    string uad = Liste.CurrentRow.Cells[0].Value.ToString();
                    var srg = (from s in db.tblUrunler
                               where s.UrunKodu == uad
                               select s).First();
                    //string uadi = srg.UrunAdi;
                    Liste.CurrentRow.Cells[1].Value = srg.UrunAdi;
                    Liste.CurrentRow.Cells[4].Value = srg.BirimTipi;
                }
                if (e.ColumnIndex == 3)
                {
                    decimal a = Convert.ToDecimal(Liste.CurrentRow.Cells[2].Value.ToString());
                    decimal b = Convert.ToDecimal(Liste.CurrentRow.Cells[3].Value.ToString());
                    decimal hesapla = a * b * 0.18M;
                    Liste.CurrentRow.Cells[5].Value = hesapla;
                    GenelToplam();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata :" + ex);
            }
        }
        private void GenelToplam()
        {
            decimal at = 0;
            decimal kt = 0;
            decimal tt = 0;
            for (int j = 0; j < Liste.RowCount - 1; j++)
            {
                at += (Convert.ToDecimal(Liste.Rows[j].Cells[2].Value.ToString())) * (Convert.ToDecimal(Liste.Rows[j].Cells[3].Value.ToString()));
                kt += (Convert.ToDecimal(Liste.Rows[j].Cells[5].Value.ToString()));
                txtAraToplam.Text = at.ToString();
                txtKdvToplam.Text = kt.ToString();

                tt = Convert.ToDecimal(txtAraToplam.Text) + (Convert.ToDecimal(txtKdvToplam.Text));
                txtToplamTutar.Text = tt.ToString();
            }
        }
        private void Sec()
        {
            try
            {
                secimId = Convert.ToInt32(Liste.CurrentRow.Cells[0].Value.ToString());
            }
            catch (Exception)
            {
                secimId = -1;
            }
        }

    }
}
