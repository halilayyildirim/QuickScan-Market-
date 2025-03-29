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
using barkodlumarketotomasyon.model;
using System.Data.SqlClient;
using barkodlumarketotomasyon.Properties;
using barkodlumarketotomasyon.enumaration;
using barkodlumarketotomasyon.dao;


namespace barkodlumarketotomasyon.controller {

    public partial class sifredegistirme : Form
    {
        public sifredegistirme()
        {
            InitializeComponent();
        }

       

        private void sifredegistirme_Load(object sender, EventArgs e)
        {
            controller controller = new controller();
            List<logintable> logintableliste= controller.guvenliksorulari();
            
    
        grpbox_sifredegistir.Enabled = false;
            foreach(logintable it in logintableliste)
            {
                cmb_gsygs.Items.Add(it.guvenliksorusu.ToString());
            }


        }

        public void islemyap(string kullaniciadi, string guvenliksorusu, string guvenlikcevabi)
        {
        }

        private void btn_sorgula_Click(object sender, EventArgs e)
        {
            controller controller= new controller();
            loginstatus result = controller.doauthentication(txt_gsykulad.Text, cmb_gsygs.SelectedItem.ToString(), txt_gsygc.Text);
            if (result == loginstatus.basarili) {
                grpbox_sifredegistir.Enabled = true;
            
            }
            else if(result==loginstatus.basarisiz)
            {
                MessageBox.Show("Hatalı değer girdiniz","HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Eksik parametre girdiniz");
            }
        }

        private void btn_sddegistir_Click(object sender, EventArgs e)
        {
            controller controller = new controller();
            

            if (txt_sdyenisifre.Text == txt_sdyst.Text)
            {
               loginstatus result= controller.changepassword(txt_sdyenisifre.Text,txt_sdyst.Text);
                if(result == loginstatus.basarili)
                {
                    MessageBox.Show("şifre güncellendi","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("eksik parametre", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("İki şifre aynı değil", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}