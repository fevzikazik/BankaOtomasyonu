using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankaOtomasyonu
{
    public partial class frm_Giris : Form
    {
        public frm_Giris()
        {
            InitializeComponent();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            if (txt_kAdi.Text == "Admin" && txt_sifre.Text == "1234")
            {
                frm_AnaSayfa frmAnaSayfa = new frm_AnaSayfa();
                frmAnaSayfa.Show();
                this.Hide();
            }
            else
            { MessageBox.Show("Hatalı Bilgi Girişi!"); }
        }
    }
    }
