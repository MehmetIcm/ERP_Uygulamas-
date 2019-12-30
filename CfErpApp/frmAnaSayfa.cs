using CfErpApp.Fonksiyonlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CfErpApp
{
    public partial class frmAnaSayfa : Form
    {
        Formlar F = new Formlar();
        public static int AktarmaInt = 1;   //bir sayfadan başka bir sayfaya anasayfa üzerinden değer aktarmak için bir değişken oluşturduk
                                            //public static int çok hızlı çalışır ram'i yorar
        public int roleId = -1;

        public frmAnaSayfa()
        {
            InitializeComponent();
        }

        private void frmAnaSayfa_Load(object sender, EventArgs e)
        {
            KurKontrol();
            RolKontrol();
        }
        public static bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://google.com/generate_204"))
                
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void RolKontrol()
        {
            if (roleId==1)
            {
                btnAdminIslemleri.Visible = true;
            }
            else
            {
                btnAdminIslemleri.Visible = false;
            }
        }

        private void KurKontrol()   //xml dosyasından veri çekme
        {
            if (frmAnaSayfa.CheckForInternetConnection())
            {
                if (txtDolar.Text == "" || txtDolar.Text == "$")
                {
                    XElement kurlar = XElement.Load("http://www.tcmb.gov.tr/kurlar/today.xml");
                    XElement dolar = (from s in kurlar.Elements()
                                      where s.Attribute("CurrencyCode")?.Value == "USD"
                                      select s).Single();
                    XElement euro = (from s in kurlar.Elements()
                                     where s.Attribute("CurrencyCode")?.Value == "EUR"
                                     select s).Single();
                    txtDolar.Text = dolar.Element("ForexBuying").Value + "$"; //forexbuying alış değerleri
                    txtEuro.Text = euro.Element("ForexBuying").Value + "€";
                }   
            }
            else
            {
                txtDolar.Text = "Yok";
                txtEuro.Text = "İnternet";
            }
        }

        private void btnBilgiGiris_Click(object sender, EventArgs e)
        {
            pnlLeft.Visible = true;
            pnlMiddle.Visible = false;
            pnlMiddle1.Visible = false;
            pnlRight.Visible = false;
            gbLeft.Text = "Bilgi Giriş Ekranı";
        }

        private void btnUrunIslemleri_Click(object sender, EventArgs e)
        {
            pnlLeft.Visible = false;
            pnlMiddle.Visible = true;
            pnlMiddle1.Visible = false;
            pnlRight.Visible = false;
            gbLeft.Text = "Ürün İşlemleri Ekranı";
        }

        private void btnDepoIslemleri_Click(object sender, EventArgs e)
        {
            pnlLeft.Visible = false;
            pnlMiddle.Visible = false;
            pnlMiddle1.Visible = false;
            pnlRight.Visible = true;
            gbLeft.Text = "Depo İşlemleri Ekranı";
        }

        private void btnFaturaIslemleri_Click(object sender, EventArgs e)
        {
            pnlLeft.Visible = false;
            pnlMiddle.Visible = false;
            pnlMiddle1.Visible = true;
            pnlRight.Visible = false;
            gbLeft.Text = "Fatura İşlemleri Ekranı";
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPersonelGiris_Click(object sender, EventArgs e)
        {
            F.PersonelGiris();
        }

        private void btnCariGiris_Click(object sender, EventArgs e)
        {
            F.CariGiris();
        }

        private void btnUrunGiris_Click(object sender, EventArgs e)
        {
            F.UrunGiris();
        }

        private void btnUrunAlis_Click(object sender, EventArgs e)
        {
            F.UrunAlis();
        }

        private void btnUrunAlisListe_Click(object sender, EventArgs e)
        {
            F.UrunAlisListesi(false);   //false gönderdiğimiz else Anaform içerisindeki mdi contanier'da açacak. (sanal butona tıklarsak)True dönerse ayrı pencere olarak açılacak 
        }

        private void btnUrunSatis_Click(object sender, EventArgs e)
        {
            F.UrunSatis();
        }

        private void btnUrunSatisListe_Click(object sender, EventArgs e)
        {
            F.UrunSatisListesi();
        }

        private void btnAdminIslemleri_Click(object sender, EventArgs e)
        {
            F.User();
        }

        private void frmAnaSayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
