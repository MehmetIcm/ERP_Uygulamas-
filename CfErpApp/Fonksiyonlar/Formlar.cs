
using CfErpApp.BilgiGiris;
using CfErpApp.Urun;
using CfErpApp.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CfErpApp.Fonksiyonlar
{
    class Formlar
    {
        #region BilgiGiris
        public void PersonelGiris()
        {
            frmPersonelGiris pers = new frmPersonelGiris();
            pers.MdiParent = frmAnaSayfa.ActiveForm;
            pers.WindowState = FormWindowState.Maximized;
            pers.Show();
        }
        public void CariGiris()
        {
            frmCariGiris cari = new frmCariGiris();
            cari.MdiParent = frmAnaSayfa.ActiveForm;
            cari.WindowState = FormWindowState.Maximized;
            cari.Show();
        }
        public void UrunGiris()
        {
            frmUrunGiris cari = new frmUrunGiris();
            cari.MdiParent = frmAnaSayfa.ActiveForm;
            cari.WindowState = FormWindowState.Maximized;
            cari.Show();
        }



        #endregion
        #region UrunIslemleri
        public void UrunAlis()
        {
            frmUrunAlis urnA = new frmUrunAlis();
            urnA.MdiParent = frmAnaSayfa.ActiveForm;
            urnA.WindowState = FormWindowState.Maximized;
            urnA.Show();
        }
        public void UrunSatis()
        {
            frmUrunSatis urnS = new frmUrunSatis();
            urnS.MdiParent = frmAnaSayfa.ActiveForm;
            urnS.WindowState = FormWindowState.Maximized;
            urnS.Show();
        }


        public int UrunAlisListesi(bool secim=false)
        {
            var ualis = new frmUrunAlisListe();
            if (secim)
            {
                ualis.Secim = true;
                ualis.ShowDialog();
            }
            else
            {
                ualis.MdiParent = Form.ActiveForm;
                ualis.WindowState = FormWindowState.Maximized;
                ualis.Show();
            }
            return frmAnaSayfa.AktarmaInt;
        }
        public int UrunSatisListesi(bool secim = false)
        {
            var usatis = new frmUrunSatisListe();
            if (secim)
            {
                usatis.Secim = true;
                usatis.ShowDialog();
            }
            else
            {
                usatis.MdiParent = Form.ActiveForm;
                usatis.WindowState = FormWindowState.Maximized;
                usatis.Show();
            }
            return frmAnaSayfa.AktarmaInt;
        }

        public void User(bool secim = false)
        {
            var user = new frmNewUser();
            if (secim)
            {
                user.Secim = true;
                user.ShowDialog();
            }   
            else
            {   
                user.MdiParent = Form.ActiveForm;
                user.WindowState = FormWindowState.Maximized;
                user.Show();
            }
        }

        #endregion
    }
}
