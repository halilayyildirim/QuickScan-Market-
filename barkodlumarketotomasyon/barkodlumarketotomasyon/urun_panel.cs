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
    public partial class urun_panel : Form
    {
        controller.controller controller = new controller.controller();
        public urun_panel()
        {
            InitializeComponent();
        }

        private void urun_panel_Load(object sender, EventArgs e)
        {
            bosalanlaridoldur();
            tumurunlerigetir();
        }

    
    public void tumurunlerigetir()
        {
           dataGridView1.DataSource= controller.tumurunlerigetir();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            admin_panel admin_Panel = new admin_panel();
            admin_Panel.Show();
            this.Hide();
        }

        private void btn_kayekle_Click(object sender, EventArgs e)
        {
            urun urun = new urun();
            urun.id =int.Parse(txt_id.Text); 
            urun.qrkod=txt_qrkod.Text;
            urun.olusturulma_traih = dt_oltarih.Value;
            urun.guncelleme_tarih = dt_guntarih.Value;
            urun.urun_isim= cmb_urunisim.SelectedIndex.ToString();
            urun.fiyat = int.Parse(txt_fiyat.Text);
            urun.kilo= float.Parse(txt_kilo.Text);
            urun.ciro=int.Parse(txt_ciro.Text);
            loginstatus sonuc = controller.urunekle(urun);
            if (sonuc == loginstatus.basarili)
            {
                MessageBox.Show("Ürün Eklendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                dataGridView1.DataSource=controller.tumurunlerigetir();
            }
            else if(sonuc==loginstatus.basarisiz)
            {
                MessageBox.Show("Ürün Eklenemedi","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
            else
            {
                MessageBox.Show("Eksik PArametre Girdiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void bosalanlaridoldur()
        {
            cmb_urunisim.Items.Add("karpuz");
            cmb_urunisim.Items.Add("domates");
            cmb_urunisim.Items.Add("soğan");
            cmb_urunisim.Items.Add("elma");
            cmb_urunisim.Items.Add("üzüm");
            cmb_urunisim.Items.Add("kiraz");
            cmb_urunisim.Items.Add("avokado");
            cmb_urunisim.Items.Add("muz");
            cmb_urunisim.Items.Add("çilek");
            cmb_urunisim.Items.Add("armut");
            cmb_urunisim.Items.Add("ananas");
            cmb_urunisim.Items.Add("portakal");
            cmb_urunisim.Items.Add("şeftali");
            cmb_urunisim.Items.Add("böğürtlen");
            cmb_urunisim.Items.Add("limon");
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_qrkod.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_barkod.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dt_oltarih.Value=DateTime.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());
            if (!string.IsNullOrEmpty(dataGridView1.CurrentRow.Cells[4].Value.ToString()))
            {
                dt_guntarih.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString());
            }
            
            cmb_urunisim.SelectedItem = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txt_kilo.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txt_fiyat.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txt_ciro.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
        }

        private void btn_kayguncelle_Click(object sender, EventArgs e)
        {
            urun urun = new urun();
            urun.id = int.Parse(txt_id.Text);
            urun.qrkod= txt_qrkod.Text;
            urun.barkodkod=txt_barkod.Text;
            urun.olusturulma_traih=DateTime.Parse(dt_oltarih.Value.ToString());
            urun.guncelleme_tarih = DateTime.Parse(dt_guntarih.Value.ToString());
            urun.urun_isim=cmb_urunisim.SelectedIndex.ToString();
            urun.fiyat= int.Parse(txt_fiyat.Text.ToString());
            urun.ciro = int.Parse(txt_ciro.Text.ToString());
            urun.kilo = float.Parse(txt_kilo.Text.ToString());

            loginstatus sonuc = controller.urunguncelle(urun);

            if (sonuc == loginstatus.basarili)
            {
                MessageBox.Show("Ürün Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = controller.tumurunlerigetir();
            }
            else if (sonuc == loginstatus.basarisiz)
            {
                MessageBox.Show("Ürün Güncellenemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                MessageBox.Show("Eksik PArametre Girdiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btn_kayseil_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_id.Text)){

                loginstatus sonuc =controller.urunsil(txt_id.Text);
                if (sonuc == loginstatus.basarili)
                {
                    MessageBox.Show("Kayıt Silindi", "Bİlgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource=controller.tumurunlerigetir();
                }
                else
                {
                    MessageBox.Show("silmek istediğiniz ürünün id değerini giriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show("silmek istediğiniz ürünün id değerini giriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}