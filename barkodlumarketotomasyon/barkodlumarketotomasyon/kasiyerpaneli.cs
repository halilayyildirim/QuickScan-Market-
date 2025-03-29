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
    public partial class kasiyerpaneli: Form
    {
        public kasiyerpaneli()
        {
            InitializeComponent();
        }

        private void btn_cikisyap_Click(object sender, EventArgs e)
        {
            girisyap girisyap = new girisyap();
            girisyap.Show();
            this.Hide();
        }

       

        private void kasiyerpaneli_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_saat.Text = DateTime.Now.Hour.ToString();
            lbl_dakika.Text = DateTime.Now.Minute.ToString();
            lbl_saniye.Text = DateTime.Now.Second.ToString();
        }

        private void btn_sebze_Click(object sender, EventArgs e)
        {
            meyvesebzepanel meyvesebze = new meyvesebzepanel();
            meyvesebze.Show();
            this.Hide();
        }
    }
}
