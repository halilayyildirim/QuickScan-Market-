using barkodlumarketotomasyon.dao;
using barkodlumarketotomasyon.enumaration;
using barkodlumarketotomasyon.model;
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
    public partial class kullanicipanel: Form
    {

        controller.controller controller = new controller.controller();
        public kullanicipanel()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void kullanicipanel_Load(object sender, EventArgs e)
        {
            defaultdegerleridoldur();
            tumkullanicilaridoldur();
        }
        private void defaultdegerleridoldur()
        {
            cmb_yetki.Items.Add("admin");
            cmb_yetki.Items.Add("kasiyer");

            cmb_guvsoru.Items.Add("en sevdiğiniz yemek");
            cmb_guvsoru.Items.Add("en sevdiğiniz şehir");
            cmb_guvsoru.Items.Add("en sevdiğiniz hayvan");
            cmb_guvsoru.Items.Add("ilkokul öğretmeninizin adı");
            cmb_guvsoru.Items.Add("tuttuğunuz takım");

        }
        private void tumkullanicilaridoldur()
        {
            controller.controller controller = new controller.controller();
            List<user> userlist = controller.tumkullanicilarigetir();
             dataGridView1.DataSource = userlist;
        }

        private void btn_kayekle_Click(object sender, EventArgs e)
        {
            user user = new user();
            user.kullaniciadi= txt_kulad.Text;
            user.sifre= txt_sifre.Text;
            user.yetki = cmb_yetki.SelectedItem.ToString();
            user.emailadres = cmb_yetki.SelectedItem.ToString();
            user.guvenliksorusu = cmb_guvsoru.SelectedItem.ToString();
            user.guvenlikcevabi = txt_guvcevap.Text;
            loginstatus sonuc =controller.kullaniciekle(user);
            if (sonuc == loginstatus.basarili)
            {
                MessageBox.Show("Kayıt Eklendi", "Teşekkkürler", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource= controller.tumkullanicilarigetir();
                
            }
            else
            {
                MessageBox.Show("Gerekli Alanları Doldurunuz","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btn_kayguncelle_Click(object sender, EventArgs e)
        {
            user user = new user();
            user.id= int.Parse(txt_id.Text);   
            user.kullaniciadi = txt_kulad.Text;
            user.sifre = txt_sifre.Text;
            user.yetki = cmb_yetki.SelectedItem.ToString();
            user.emailadres = cmb_yetki.SelectedItem.ToString();
            user.guvenliksorusu = cmb_guvsoru.SelectedItem.ToString();
            user.guvenlikcevabi = txt_guvcevap.Text;
            loginstatus sonuc = controller.kullaniciguncelle(user);
            if (sonuc == loginstatus.basarili)
            {
                MessageBox.Show("Kayıt Güncellendi", "Teşekkkürler", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = controller.tumkullanicilarigetir();

            }
            else
            {
                MessageBox.Show("Bir Hata Oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_kayseil_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_id.Text)){
                loginstatus sonuc = controller.kullanicisilme(int.Parse(txt_id.Text));
                if (sonuc == loginstatus.basarili)
                {
                    MessageBox.Show("Kayıt Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = controller.tumkullanicilarigetir();
                }
                
                else if (sonuc == loginstatus.basarisiz)
                {
                    MessageBox.Show("Kayıt Silinemedi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Eksik Parametre girdiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Eksik Parametre girdiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            admin_panel admin_Panel = new admin_panel();
            admin_Panel.Show();
            this.Hide();
        }
    }
}
