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
    public partial class frmUserGiris : Form
    {
        CfErpContext db = new CfErpContext();
        public frmUserGiris()
        {
            InitializeComponent();
        }

        private void frmUserGiris_Load(object sender, EventArgs e)
        {
            //KayitKontrol();
        }

        private void KayitKontrol()
        {
            try
            {
                var srg = (from s in db.tblUsers
                           where s.UserName == txtUserName.Text && s.Sifre == txtSifre.Text
                           select s).First().Id;
                if (srg > 0)
                {
                    
                    frmAnaSayfa frm = new frmAnaSayfa();
                    frm.WindowState = FormWindowState.Maximized;
                    frm.roleId = db.tblUsers.First(x => x.Id == srg).Role;
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı giriş yaptınız. Lütfen tekrar deneyiniz.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı giriş yaptınız. Lütfen tekrar deneyiniz."); //internet bağlı değilse catch çalışır
            }
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            KayitKontrol();
        }

        private void txtSifre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnGiris_Click(this, new EventArgs());
            }
        }
    }
}
