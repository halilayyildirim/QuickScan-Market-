using System;
using System.Windows.Forms;

namespace barkodlumarketotomasyon
{
    partial class kullanicipanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kullanicipanel));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cmb_yetki = new System.Windows.Forms.ComboBox();
            this.cmb_guvsoru = new System.Windows.Forms.ComboBox();
            this.btn_kayseil = new System.Windows.Forms.Button();
            this.btn_kayguncelle = new System.Windows.Forms.Button();
            this.btn_kayekle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_guvcevap = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.txt_kulad = new System.Windows.Forms.TextBox();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-3, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(791, 184);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cmb_yetki);
            this.groupBox1.Controls.Add(this.cmb_guvsoru);
            this.groupBox1.Controls.Add(this.btn_kayseil);
            this.groupBox1.Controls.Add(this.btn_kayguncelle);
            this.groupBox1.Controls.Add(this.btn_kayekle);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_guvcevap);
            this.groupBox1.Controls.Add(this.txt_email);
            this.groupBox1.Controls.Add(this.txt_id);
            this.groupBox1.Controls.Add(this.txt_sifre);
            this.groupBox1.Controls.Add(this.txt_kulad);
            this.groupBox1.Location = new System.Drawing.Point(-3, 215);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(791, 291);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı Panel";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageIndex = 1;
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(670, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "Geri git";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmb_yetki
            // 
            this.cmb_yetki.FormattingEnabled = true;
            this.cmb_yetki.Location = new System.Drawing.Point(118, 178);
            this.cmb_yetki.Name = "cmb_yetki";
            this.cmb_yetki.Size = new System.Drawing.Size(100, 24);
            this.cmb_yetki.TabIndex = 3;
            // 
            // cmb_guvsoru
            // 
            this.cmb_guvsoru.FormattingEnabled = true;
            this.cmb_guvsoru.Location = new System.Drawing.Point(424, 88);
            this.cmb_guvsoru.Name = "cmb_guvsoru";
            this.cmb_guvsoru.Size = new System.Drawing.Size(151, 24);
            this.cmb_guvsoru.TabIndex = 3;
            // 
            // btn_kayseil
            // 
            this.btn_kayseil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kayseil.ImageIndex = 2;
            this.btn_kayseil.ImageList = this.ımageList1;
            this.btn_kayseil.Location = new System.Drawing.Point(628, 130);
            this.btn_kayseil.Name = "btn_kayseil";
            this.btn_kayseil.Size = new System.Drawing.Size(120, 24);
            this.btn_kayseil.TabIndex = 2;
            this.btn_kayseil.Text = "Kayıt Sil";
            this.btn_kayseil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_kayseil.UseVisualStyleBackColor = true;
            this.btn_kayseil.Click += new System.EventHandler(this.btn_kayseil_Click);
            // 
            // btn_kayguncelle
            // 
            this.btn_kayguncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kayguncelle.ImageIndex = 3;
            this.btn_kayguncelle.ImageList = this.ımageList1;
            this.btn_kayguncelle.Location = new System.Drawing.Point(628, 81);
            this.btn_kayguncelle.Name = "btn_kayguncelle";
            this.btn_kayguncelle.Size = new System.Drawing.Size(120, 31);
            this.btn_kayguncelle.TabIndex = 2;
            this.btn_kayguncelle.Text = "Kayıt Güncelle";
            this.btn_kayguncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_kayguncelle.UseVisualStyleBackColor = true;
            this.btn_kayguncelle.Click += new System.EventHandler(this.btn_kayguncelle_Click);
            // 
            // btn_kayekle
            // 
            this.btn_kayekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kayekle.ImageIndex = 0;
            this.btn_kayekle.ImageList = this.ımageList1;
            this.btn_kayekle.Location = new System.Drawing.Point(628, 40);
            this.btn_kayekle.Name = "btn_kayekle";
            this.btn_kayekle.Size = new System.Drawing.Size(120, 35);
            this.btn_kayekle.TabIndex = 2;
            this.btn_kayekle.Text = "Kayıt Ekle ";
            this.btn_kayekle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_kayekle.UseVisualStyleBackColor = true;
            this.btn_kayekle.Click += new System.EventHandler(this.btn_kayekle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(276, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Güvenlik Cevabı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(277, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Güvenlik Sorusu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(301, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Email Adres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Yetki";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(68, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // txt_guvcevap
            // 
            this.txt_guvcevap.Location = new System.Drawing.Point(424, 132);
            this.txt_guvcevap.Name = "txt_guvcevap";
            this.txt_guvcevap.Size = new System.Drawing.Size(151, 22);
            this.txt_guvcevap.TabIndex = 0;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(424, 37);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(151, 22);
            this.txt_email.TabIndex = 0;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(118, 43);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 22);
            this.txt_id.TabIndex = 0;
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(118, 132);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(100, 22);
            this.txt_sifre.TabIndex = 0;
            // 
            // txt_kulad
            // 
            this.txt_kulad.Location = new System.Drawing.Point(118, 85);
            this.txt_kulad.Name = "txt_kulad";
            this.txt_kulad.Size = new System.Drawing.Size(100, 22);
            this.txt_kulad.TabIndex = 0;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "1564491_add_create_new_plus_icon.ico");
            this.ımageList1.Images.SetKeyName(1, "4470662_app_back_mobile_ui_ux_icon.ico");
            this.ımageList1.Images.SetKeyName(2, "1564502_basket_delete_remove_icon.ico");
            this.ımageList1.Images.SetKeyName(3, "134221_refresh_reload_repeat_update_arrow_icon.ico");
            // 
            // kullanicipanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 532);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "kullanicipanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "kullanicipanel";
            this.Load += new System.EventHandler(this.kullanicipanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_kulad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_guvcevap;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.ComboBox cmb_guvsoru;
        private System.Windows.Forms.Button btn_kayseil;
        private System.Windows.Forms.Button btn_kayguncelle;
        private System.Windows.Forms.Button btn_kayekle;
        private System.Windows.Forms.ComboBox cmb_yetki;
        private Label label7;
        private TextBox txt_id;
        private Button button1;
        private ImageList ımageList1;
    }
}