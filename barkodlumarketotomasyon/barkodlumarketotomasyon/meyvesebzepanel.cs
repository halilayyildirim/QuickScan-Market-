using AForge.Video.DirectShow;
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
using ZXing;

namespace barkodlumarketotomasyon
{
    public partial class meyvesebzepanel : Form
    {

        int sayi1, sayi2;
        int islemtip;
        public meyvesebzepanel()
        {
            InitializeComponent();
            txt_islem.Text = "0";

        }

        private void grp_name_Enter(object sender, EventArgs e)
        {

        }
        VideoCaptureDevice vcd;
        FilterInfoCollection fic;

        private void meyvesebzepanel_Load(object sender, EventArgs e)
        {
            fic = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo camera in fic)
            {
                cmb_kamera.Items.Add(camera.Name);
            }

        }

        private void secilentus(object sender, EventArgs e)
        {

        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            txt_islem.Text = "0";
        }

        private void txt_esittir_Click(object sender, EventArgs e)
        {
            if (islemtip==1)
            {
                sayi2 = int.Parse(txt_islem.Text);
                txt_islem.Text = (sayi1 + sayi2).ToString();
            }
            else if (islemtip==2)
            {
                sayi2 = int.Parse(txt_islem.Text);
                txt_islem.Text = (sayi1 - sayi2).ToString();
            }
            else if (islemtip==3)
            {
                sayi2 = int.Parse(txt_islem.Text);
                txt_islem.Text = (sayi1 * sayi2).ToString();
            }
            else if(islemtip==4)
            {
                sayi2 = int.Parse(txt_islem.Text);
                txt_islem.Text = (sayi1 / sayi2).ToString();
            }
        }
            

        private void txt_eksi_Click(object sender, EventArgs e)
        {
            islemtip = 2;
            sayi1 = int.Parse(txt_islem.Text);
            txt_islem.Text = "0";

        }

        private void txt_carpi_Click(object sender, EventArgs e)
        {
            islemtip = 3;
            sayi1 = int.Parse(txt_islem.Text);
            txt_islem.Text = "0";
        }

        private void txt_bolu_Click(object sender, EventArgs e)
        {
            islemtip = 4;
            sayi1 = int.Parse(txt_islem.Text);
            txt_islem.Text = "0";
        }

        private void txt_gerigit_Click(object sender, EventArgs e)
        {
            if (txt_islem.Text.Length != 0)
            {
                txt_islem.Text = txt_islem.Text.Substring(0, txt_islem.Text.Length - 1);
            }
            else
            {
                txt_islem.Text = "0";
            }
        }
        

        private void btn_kameraac_Click(object sender, EventArgs e)
        {
            vcd = new VideoCaptureDevice(fic[cmb_kamera.SelectedIndex].MonikerString);
            vcd.NewFrame += Vcd_NewFrame;
            vcd.Start();
            timer1.Start();
        }

        private void Vcd_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            pcbox_kamera.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void btn_kamerakapat_Click(object sender, EventArgs e)
        {
            vcd.Stop();
            pcbox_kamera.Image = Image.FromFile(@"C:\Users\hp\Downloads\icons8-lens-50.ico");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pcbox_kamera != null) {
                BarcodeReader Reader = new BarcodeReader();
                Result result = Reader.Decode((Bitmap)pcbox_kamera.Image);
                if (result != null) {
                    textBox16.Text = result.ToString();
                    timer1.Stop();
                }
            }
        }

        private void meyvesebzepanel_MouseCaptureChanged(object sender, EventArgs e)
        {
            if (txt_islem.Text == "0")
            {
                txt_islem.Text = "";
            }

            var button = sender as Button;
            if (button != null)
            {
                txt_islem.Text += button.Text;
            }
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            controller.controller controller= new controller.controller();
           urun urun= controller.urungetir(textBox16.Text);
            txt_islem.Text= urun.fiyat.ToString();
        }

        private void txt_arti_Click(object sender, EventArgs e)
        {
            islemtip = 1;
            sayi1=int.Parse(txt_islem.Text);
            txt_islem.Text = "0";
        }
    }
}
