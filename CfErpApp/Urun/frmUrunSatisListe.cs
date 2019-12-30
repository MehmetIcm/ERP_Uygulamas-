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
    public partial class frmUrunSatisListe : Form
    {
        CfErpContext db = new CfErpContext();
        public bool Secim = false;
        int secimId = -1;
        public frmUrunSatisListe()
        {
            InitializeComponent();
        }

        private void frmUrunSatisListe_Load(object sender, EventArgs e)
        {
            Listele();
        }
        private void Listele()
        {
            Liste.Rows.Clear();
            var lst = (from s in db.tblUrunSatis
                       where s.TblCari.CariAdi.Contains(txtCariAdi.Text)
                       select new
                       {
                           usatis = s.UrunSatisNo,
                           cadi = s.TblCari.CariAdi,
                           star = s.SatisTarih,
                       }).Distinct().ToList();
            int i = 0;
            foreach (var k in lst)
            {
                Liste.Rows.Add();
                //Liste.Rows[i].Cells[0].Value = k.Id;
                Liste.Rows[i].Cells[0].Value = k.usatis;
                Liste.Rows[i].Cells[1].Value = k.cadi;
                Liste.Rows[i].Cells[2].Value = k.star;
                i++;
            }
            Liste.AllowUserToAddRows = false;
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if (Secim && secimId > 0)
            {
                frmAnaSayfa.AktarmaInt = secimId;
                Close();
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
