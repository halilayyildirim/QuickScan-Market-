using barkodlumarketotomasyon.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace barkodlumarketotomasyon
{
    public partial class admin_panel: Form
    {
        public admin_panel()
        {
            InitializeComponent();
        }

        private void lbl_saat_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_saat.Text = DateTime.Now.Hour.ToString();
            lbl_dakika.Text = DateTime.Now.Minute.ToString();
            lbl_saniye.Text = DateTime.Now.Second.ToString();
        }

        private void admin_panel_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            kullanicipanel kullanicipanel = new kullanicipanel();
            kullanicipanel.Show();
            this.Hide();
        }

        private void btn_depo_Click(object sender, EventArgs e)
        {
            urun_panel urun = new urun_panel();
            urun.Show();
            this.Hide();
        }

        private void btn_cikisyap_Click(object sender, EventArgs e)
        {
            girisyap girisyap = new girisyap();
            girisyap.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
