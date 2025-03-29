using System;
using System.Windows.Forms;
using barkodlumarketotomasyon.controller;
using barkodlumarketotomasyon.enumaration;
using barkodlumarketotomasyon.model;

namespace barkodlumarketotomasyon.controller
{
    public partial class girisyap : Form
    {
        public girisyap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
             {
                
                controller controllerInstance = new controller();

                
                user result = controllerInstance.login(txt_kulad.Text, txt_sifre.Text);

                if (result != null && result.status == loginstatus.basarili && result.yetki == "admin")
                {
                    admin_panel admin= new admin_panel();
                    admin.Show();
                    this.Hide();
                }
                else if(result!=null && result.status==loginstatus.basarili&&result.yetki=="kasiyer" ){

                    kasiyerpaneli kasiyer = new kasiyerpaneli();
                    kasiyer.Show();
                    this.Hide();
                }
                else if(result!=null && result.status==loginstatus.basarisiz)
                {
                    MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Eksik Parametre Hatası","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }

                    
                

            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_girissfrunuttum_Click(object sender, EventArgs e)
        {
            try
            {
                
                sifredegistirme sd = new sifredegistirme();
                sd.ShowDialog(); 
                this.Close(); 
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}