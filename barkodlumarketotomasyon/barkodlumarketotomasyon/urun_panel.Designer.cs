namespace barkodlumarketotomasyon
{
    partial class urun_panel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(urun_panel));
            this.grp_urunpanel = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cmb_urunisim = new System.Windows.Forms.ComboBox();
            this.btn_kayseil = new System.Windows.Forms.Button();
            this.btn_kayguncelle = new System.Windows.Forms.Button();
            this.btn_kayekle = new System.Windows.Forms.Button();
            this.lbl_fiyat = new System.Windows.Forms.Label();
            this.lbl_kilo = new System.Windows.Forms.Label();
            this.lbl_urunisim = new System.Windows.Forms.Label();
            this.lbl_oltarih = new System.Windows.Forms.Label();
            this.lbl_barkod = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_qrkod = new System.Windows.Forms.Label();
            this.txt_fiyat = new System.Windows.Forms.TextBox();
            this.txt_kilo = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_barkod = new System.Windows.Forms.TextBox();
            this.txt_qrkod = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_guntarih = new System.Windows.Forms.Label();
            this.dt_oltarih = new System.Windows.Forms.DateTimePicker();
            this.dt_guntarih = new System.Windows.Forms.DateTimePicker();
            this.txt_ciro = new System.Windows.Forms.TextBox();
            this.lbl_ciro = new System.Windows.Forms.Label();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.grp_urunpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_urunpanel
            // 
            this.grp_urunpanel.Controls.Add(this.dt_guntarih);
            this.grp_urunpanel.Controls.Add(this.dt_oltarih);
            this.grp_urunpanel.Controls.Add(this.button1);
            this.grp_urunpanel.Controls.Add(this.cmb_urunisim);
            this.grp_urunpanel.Controls.Add(this.btn_kayseil);
            this.grp_urunpanel.Controls.Add(this.btn_kayguncelle);
            this.grp_urunpanel.Controls.Add(this.btn_kayekle);
            this.grp_urunpanel.Controls.Add(this.lbl_ciro);
            this.grp_urunpanel.Controls.Add(this.lbl_fiyat);
            this.grp_urunpanel.Controls.Add(this.lbl_kilo);
            this.grp_urunpanel.Controls.Add(this.lbl_urunisim);
            this.grp_urunpanel.Controls.Add(this.lbl_oltarih);
            this.grp_urunpanel.Controls.Add(this.lbl_guntarih);
            this.grp_urunpanel.Controls.Add(this.lbl_barkod);
            this.grp_urunpanel.Controls.Add(this.label7);
            this.grp_urunpanel.Controls.Add(this.lbl_qrkod);
            this.grp_urunpanel.Controls.Add(this.txt_ciro);
            this.grp_urunpanel.Controls.Add(this.txt_fiyat);
            this.grp_urunpanel.Controls.Add(this.txt_kilo);
            this.grp_urunpanel.Controls.Add(this.txt_id);
            this.grp_urunpanel.Controls.Add(this.txt_barkod);
            this.grp_urunpanel.Controls.Add(this.txt_qrkod);
            this.grp_urunpanel.Location = new System.Drawing.Point(5, 245);
            this.grp_urunpanel.Name = "grp_urunpanel";
            this.grp_urunpanel.Size = new System.Drawing.Size(791, 322);
            this.grp_urunpanel.TabIndex = 3;
            this.grp_urunpanel.TabStop = false;
            this.grp_urunpanel.Text = "Ürün Panel";
            // 
            // button1
            // 
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageIndex = 1;
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(662, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 12;
            this.button1.Text = "Geri git";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmb_urunisim
            // 
            this.cmb_urunisim.FormattingEnabled = true;
            this.cmb_urunisim.Location = new System.Drawing.Point(424, 39);
            this.cmb_urunisim.Name = "cmb_urunisim";
            this.cmb_urunisim.Size = new System.Drawing.Size(151, 24);
            this.cmb_urunisim.TabIndex = 5;
            // 
            // btn_kayseil
            // 
            this.btn_kayseil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kayseil.ImageIndex = 2;
            this.btn_kayseil.ImageList = this.ımageList1;
            this.btn_kayseil.Location = new System.Drawing.Point(626, 128);
            this.btn_kayseil.Name = "btn_kayseil";
            this.btn_kayseil.Size = new System.Drawing.Size(122, 33);
            this.btn_kayseil.TabIndex = 11;
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
            this.btn_kayguncelle.Location = new System.Drawing.Point(626, 81);
            this.btn_kayguncelle.Name = "btn_kayguncelle";
            this.btn_kayguncelle.Size = new System.Drawing.Size(122, 38);
            this.btn_kayguncelle.TabIndex = 10;
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
            this.btn_kayekle.Location = new System.Drawing.Point(626, 43);
            this.btn_kayekle.Name = "btn_kayekle";
            this.btn_kayekle.Size = new System.Drawing.Size(122, 32);
            this.btn_kayekle.TabIndex = 9;
            this.btn_kayekle.Text = "Kayıt Ekle ";
            this.btn_kayekle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_kayekle.UseVisualStyleBackColor = true;
            this.btn_kayekle.Click += new System.EventHandler(this.btn_kayekle_Click);
            // 
            // lbl_fiyat
            // 
            this.lbl_fiyat.AutoSize = true;
            this.lbl_fiyat.Location = new System.Drawing.Point(338, 135);
            this.lbl_fiyat.Name = "lbl_fiyat";
            this.lbl_fiyat.Size = new System.Drawing.Size(36, 16);
            this.lbl_fiyat.TabIndex = 1;
            this.lbl_fiyat.Text = "Fiyat";
            // 
            // lbl_kilo
            // 
            this.lbl_kilo.AutoSize = true;
            this.lbl_kilo.Location = new System.Drawing.Point(345, 88);
            this.lbl_kilo.Name = "lbl_kilo";
            this.lbl_kilo.Size = new System.Drawing.Size(29, 16);
            this.lbl_kilo.TabIndex = 1;
            this.lbl_kilo.Text = "Kilo";
            // 
            // lbl_urunisim
            // 
            this.lbl_urunisim.AutoSize = true;
            this.lbl_urunisim.Location = new System.Drawing.Point(312, 40);
            this.lbl_urunisim.Name = "lbl_urunisim";
            this.lbl_urunisim.Size = new System.Drawing.Size(62, 16);
            this.lbl_urunisim.TabIndex = 1;
            this.lbl_urunisim.Text = "Ürün İsim";
            // 
            // lbl_oltarih
            // 
            this.lbl_oltarih.AutoSize = true;
            this.lbl_oltarih.Location = new System.Drawing.Point(4, 175);
            this.lbl_oltarih.Name = "lbl_oltarih";
            this.lbl_oltarih.Size = new System.Drawing.Size(111, 16);
            this.lbl_oltarih.TabIndex = 1;
            this.lbl_oltarih.Text = "Oluşturulma Tarih";
            // 
            // lbl_barkod
            // 
            this.lbl_barkod.AutoSize = true;
            this.lbl_barkod.Location = new System.Drawing.Point(37, 132);
            this.lbl_barkod.Name = "lbl_barkod";
            this.lbl_barkod.Size = new System.Drawing.Size(78, 16);
            this.lbl_barkod.TabIndex = 1;
            this.lbl_barkod.Text = "Barkod Kod";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(97, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Id";
            // 
            // lbl_qrkod
            // 
            this.lbl_qrkod.AutoSize = true;
            this.lbl_qrkod.Location = new System.Drawing.Point(67, 85);
            this.lbl_qrkod.Name = "lbl_qrkod";
            this.lbl_qrkod.Size = new System.Drawing.Size(48, 16);
            this.lbl_qrkod.TabIndex = 1;
            this.lbl_qrkod.Text = "Qr Kod";
            // 
            // txt_fiyat
            // 
            this.txt_fiyat.Location = new System.Drawing.Point(424, 132);
            this.txt_fiyat.Name = "txt_fiyat";
            this.txt_fiyat.Size = new System.Drawing.Size(151, 22);
            this.txt_fiyat.TabIndex = 7;
            // 
            // txt_kilo
            // 
            this.txt_kilo.Location = new System.Drawing.Point(424, 85);
            this.txt_kilo.Name = "txt_kilo";
            this.txt_kilo.Size = new System.Drawing.Size(151, 22);
            this.txt_kilo.TabIndex = 6;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(133, 39);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(127, 22);
            this.txt_id.TabIndex = 0;
            // 
            // txt_barkod
            // 
            this.txt_barkod.Location = new System.Drawing.Point(133, 128);
            this.txt_barkod.Name = "txt_barkod";
            this.txt_barkod.Size = new System.Drawing.Size(127, 22);
            this.txt_barkod.TabIndex = 2;
            // 
            // txt_qrkod
            // 
            this.txt_qrkod.Location = new System.Drawing.Point(133, 81);
            this.txt_qrkod.Name = "txt_qrkod";
            this.txt_qrkod.Size = new System.Drawing.Size(127, 22);
            this.txt_qrkod.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(791, 184);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // lbl_guntarih
            // 
            this.lbl_guntarih.AutoSize = true;
            this.lbl_guntarih.Location = new System.Drawing.Point(2, 225);
            this.lbl_guntarih.Name = "lbl_guntarih";
            this.lbl_guntarih.Size = new System.Drawing.Size(113, 16);
            this.lbl_guntarih.TabIndex = 1;
            this.lbl_guntarih.Text = "Güncelleme Tarih";
            // 
            // dt_oltarih
            // 
            this.dt_oltarih.Location = new System.Drawing.Point(133, 175);
            this.dt_oltarih.Name = "dt_oltarih";
            this.dt_oltarih.Size = new System.Drawing.Size(127, 22);
            this.dt_oltarih.TabIndex = 3;
            // 
            // dt_guntarih
            // 
            this.dt_guntarih.Location = new System.Drawing.Point(133, 219);
            this.dt_guntarih.Name = "dt_guntarih";
            this.dt_guntarih.Size = new System.Drawing.Size(127, 22);
            this.dt_guntarih.TabIndex = 4;
            // 
            // txt_ciro
            // 
            this.txt_ciro.Location = new System.Drawing.Point(424, 175);
            this.txt_ciro.Name = "txt_ciro";
            this.txt_ciro.Size = new System.Drawing.Size(151, 22);
            this.txt_ciro.TabIndex = 8;
            // 
            // lbl_ciro
            // 
            this.lbl_ciro.AutoSize = true;
            this.lbl_ciro.Location = new System.Drawing.Point(338, 178);
            this.lbl_ciro.Name = "lbl_ciro";
            this.lbl_ciro.Size = new System.Drawing.Size(31, 16);
            this.lbl_ciro.TabIndex = 1;
            this.lbl_ciro.Text = "Ciro";
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
            // urun_panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 579);
            this.Controls.Add(this.grp_urunpanel);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "urun_panel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "urun_panel";
            this.Load += new System.EventHandler(this.urun_panel_Load);
            this.grp_urunpanel.ResumeLayout(false);
            this.grp_urunpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_urunpanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmb_urunisim;
        private System.Windows.Forms.Button btn_kayseil;
        private System.Windows.Forms.Button btn_kayguncelle;
        private System.Windows.Forms.Button btn_kayekle;
        private System.Windows.Forms.Label lbl_fiyat;
        private System.Windows.Forms.Label lbl_kilo;
        private System.Windows.Forms.Label lbl_urunisim;
        private System.Windows.Forms.Label lbl_oltarih;
        private System.Windows.Forms.Label lbl_barkod;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_qrkod;
        private System.Windows.Forms.TextBox txt_fiyat;
        private System.Windows.Forms.TextBox txt_kilo;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_barkod;
        private System.Windows.Forms.TextBox txt_qrkod;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_guntarih;
        private System.Windows.Forms.DateTimePicker dt_guntarih;
        private System.Windows.Forms.DateTimePicker dt_oltarih;
        private System.Windows.Forms.Label lbl_ciro;
        private System.Windows.Forms.TextBox txt_ciro;
        private System.Windows.Forms.ImageList ımageList1;
    }
}