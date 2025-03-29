namespace barkodlumarketotomasyon
{
    partial class kasiyerpaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kasiyerpaneli));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_et = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.btn_sebze = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_bakla = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_sut = new System.Windows.Forms.Button();
            this.btn_cikisyap = new System.Windows.Forms.Button();
            this.lbl_saniye = new System.Windows.Forms.Label();
            this.lbl_dakika = new System.Windows.Forms.Label();
            this.lbl_saat = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 0;
            // 
            // btn_et
            // 
            this.btn_et.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_et.ImageIndex = 0;
            this.btn_et.ImageList = this.ımageList1;
            this.btn_et.Location = new System.Drawing.Point(83, 89);
            this.btn_et.Name = "btn_et";
            this.btn_et.Size = new System.Drawing.Size(186, 110);
            this.btn_et.TabIndex = 1;
            this.btn_et.UseVisualStyleBackColor = true;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "meat.ico");
            this.ımageList1.Images.SetKeyName(1, "shopping-bag.ico");
            this.ımageList1.Images.SetKeyName(2, "dairy-products.ico");
            this.ımageList1.Images.SetKeyName(3, "legumes.ico");
            this.ımageList1.Images.SetKeyName(4, "letter-x.ico");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 0;
            // 
            // btn_sebze
            // 
            this.btn_sebze.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sebze.ImageIndex = 1;
            this.btn_sebze.ImageList = this.ımageList1;
            this.btn_sebze.Location = new System.Drawing.Point(83, 205);
            this.btn_sebze.Name = "btn_sebze";
            this.btn_sebze.Size = new System.Drawing.Size(186, 110);
            this.btn_sebze.TabIndex = 1;
            this.btn_sebze.UseVisualStyleBackColor = true;
            this.btn_sebze.Click += new System.EventHandler(this.btn_sebze_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(334, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 0;
            // 
            // btn_bakla
            // 
            this.btn_bakla.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_bakla.ImageIndex = 3;
            this.btn_bakla.ImageList = this.ımageList1;
            this.btn_bakla.Location = new System.Drawing.Point(83, 445);
            this.btn_bakla.Name = "btn_bakla";
            this.btn_bakla.Size = new System.Drawing.Size(186, 123);
            this.btn_bakla.TabIndex = 1;
            this.btn_bakla.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 0;
            // 
            // btn_sut
            // 
            this.btn_sut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sut.ImageIndex = 2;
            this.btn_sut.ImageList = this.ımageList1;
            this.btn_sut.Location = new System.Drawing.Point(83, 321);
            this.btn_sut.Name = "btn_sut";
            this.btn_sut.Size = new System.Drawing.Size(186, 118);
            this.btn_sut.TabIndex = 1;
            this.btn_sut.UseVisualStyleBackColor = true;
            // 
            // btn_cikisyap
            // 
            this.btn_cikisyap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cikisyap.ImageIndex = 4;
            this.btn_cikisyap.ImageList = this.ımageList1;
            this.btn_cikisyap.Location = new System.Drawing.Point(327, 97);
            this.btn_cikisyap.Margin = new System.Windows.Forms.Padding(20);
            this.btn_cikisyap.Name = "btn_cikisyap";
            this.btn_cikisyap.Size = new System.Drawing.Size(119, 95);
            this.btn_cikisyap.TabIndex = 2;
            this.btn_cikisyap.Text = "Çıkış Yap";
            this.btn_cikisyap.UseVisualStyleBackColor = true;
            this.btn_cikisyap.Click += new System.EventHandler(this.btn_cikisyap_Click);
            // 
            // lbl_saniye
            // 
            this.lbl_saniye.AutoSize = true;
            this.lbl_saniye.Location = new System.Drawing.Point(384, 47);
            this.lbl_saniye.Name = "lbl_saniye";
            this.lbl_saniye.Size = new System.Drawing.Size(21, 16);
            this.lbl_saniye.TabIndex = 3;
            this.lbl_saniye.Text = "00";
            // 
            // lbl_dakika
            // 
            this.lbl_dakika.AutoSize = true;
            this.lbl_dakika.Location = new System.Drawing.Point(362, 47);
            this.lbl_dakika.Name = "lbl_dakika";
            this.lbl_dakika.Size = new System.Drawing.Size(21, 16);
            this.lbl_dakika.TabIndex = 3;
            this.lbl_dakika.Text = "00";
            // 
            // lbl_saat
            // 
            this.lbl_saat.AutoSize = true;
            this.lbl_saat.Location = new System.Drawing.Point(334, 47);
            this.lbl_saat.Name = "lbl_saat";
            this.lbl_saat.Size = new System.Drawing.Size(21, 16);
            this.lbl_saat.TabIndex = 3;
            this.lbl_saat.Text = "00";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // kasiyerpaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(504, 689);
            this.Controls.Add(this.lbl_saat);
            this.Controls.Add(this.lbl_dakika);
            this.Controls.Add(this.lbl_saniye);
            this.Controls.Add(this.btn_cikisyap);
            this.Controls.Add(this.btn_sut);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_bakla);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_sebze);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_et);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "kasiyerpaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "kasiyerpaneli";
            this.Load += new System.EventHandler(this.kasiyerpaneli_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_et;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_sebze;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_bakla;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_sut;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btn_cikisyap;
        private System.Windows.Forms.Label lbl_saniye;
        private System.Windows.Forms.Label lbl_dakika;
        private System.Windows.Forms.Label lbl_saat;
        private System.Windows.Forms.Timer timer1;
    }
}