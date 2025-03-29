namespace barkodlumarketotomasyon
{
    partial class admin_panel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_panel));
            this.lbl_saat = new System.Windows.Forms.Label();
            this.lbl_dakika = new System.Windows.Forms.Label();
            this.lbl_saniye = new System.Windows.Forms.Label();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_cikisyap = new System.Windows.Forms.Button();
            this.btn_depo = new System.Windows.Forms.Button();
            this.btn_admin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_saat
            // 
            this.lbl_saat.AutoSize = true;
            this.lbl_saat.Location = new System.Drawing.Point(387, 9);
            this.lbl_saat.Name = "lbl_saat";
            this.lbl_saat.Size = new System.Drawing.Size(21, 16);
            this.lbl_saat.TabIndex = 4;
            this.lbl_saat.Text = "00";
            this.lbl_saat.Click += new System.EventHandler(this.lbl_saat_Click);
            // 
            // lbl_dakika
            // 
            this.lbl_dakika.AutoSize = true;
            this.lbl_dakika.Location = new System.Drawing.Point(415, 9);
            this.lbl_dakika.Name = "lbl_dakika";
            this.lbl_dakika.Size = new System.Drawing.Size(21, 16);
            this.lbl_dakika.TabIndex = 5;
            this.lbl_dakika.Text = "00";
            // 
            // lbl_saniye
            // 
            this.lbl_saniye.AutoSize = true;
            this.lbl_saniye.Location = new System.Drawing.Point(437, 9);
            this.lbl_saniye.Name = "lbl_saniye";
            this.lbl_saniye.Size = new System.Drawing.Size(21, 16);
            this.lbl_saniye.TabIndex = 6;
            this.lbl_saniye.Text = "00";
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "62590_goods_palet_products_shipment_shipping_icon.ico");
            this.ımageList1.Images.SetKeyName(1, "Hopstarter-Sleek-Xp-Basic-Administrator.256.ico");
            this.ımageList1.Images.SetKeyName(2, "131507_hacker_administrator_system_sys_hack_icon.ico");
            // 
            // ımageList2
            // 
            this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList2.Images.SetKeyName(0, "619539_close_delete_dismiss_exit_cancel_icon.ico");
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_cikisyap
            // 
            this.btn_cikisyap.ImageIndex = 0;
            this.btn_cikisyap.ImageList = this.ımageList2;
            this.btn_cikisyap.Location = new System.Drawing.Point(188, 280);
            this.btn_cikisyap.Name = "btn_cikisyap";
            this.btn_cikisyap.Size = new System.Drawing.Size(93, 84);
            this.btn_cikisyap.TabIndex = 7;
            this.btn_cikisyap.UseVisualStyleBackColor = true;
            this.btn_cikisyap.Click += new System.EventHandler(this.btn_cikisyap_Click);
            // 
            // btn_depo
            // 
            this.btn_depo.ImageIndex = 0;
            this.btn_depo.ImageList = this.ımageList1;
            this.btn_depo.Location = new System.Drawing.Point(306, 72);
            this.btn_depo.Name = "btn_depo";
            this.btn_depo.Size = new System.Drawing.Size(130, 156);
            this.btn_depo.TabIndex = 7;
            this.btn_depo.UseVisualStyleBackColor = true;
            this.btn_depo.Click += new System.EventHandler(this.btn_depo_Click);
            // 
            // btn_admin
            // 
            this.btn_admin.ImageIndex = 2;
            this.btn_admin.ImageList = this.ımageList1;
            this.btn_admin.Location = new System.Drawing.Point(47, 72);
            this.btn_admin.Name = "btn_admin";
            this.btn_admin.Size = new System.Drawing.Size(130, 156);
            this.btn_admin.TabIndex = 7;
            this.btn_admin.UseVisualStyleBackColor = true;
            this.btn_admin.Click += new System.EventHandler(this.btn_admin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "KASİYER PANEL";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "ÜRÜN PANEL";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "ÇIKIŞ YAP";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // admin_panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 418);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cikisyap);
            this.Controls.Add(this.btn_depo);
            this.Controls.Add(this.btn_admin);
            this.Controls.Add(this.lbl_saat);
            this.Controls.Add(this.lbl_dakika);
            this.Controls.Add(this.lbl_saniye);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "admin_panel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "admin_panel";
            this.Load += new System.EventHandler(this.admin_panel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_saat;
        private System.Windows.Forms.Label lbl_dakika;
        private System.Windows.Forms.Label lbl_saniye;
        private System.Windows.Forms.Button btn_admin;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btn_depo;
        private System.Windows.Forms.Button btn_cikisyap;
        private System.Windows.Forms.ImageList ımageList2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}