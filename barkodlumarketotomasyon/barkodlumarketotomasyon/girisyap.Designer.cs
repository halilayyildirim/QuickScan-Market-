namespace barkodlumarketotomasyon.controller
{
    partial class girisyap
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(girisyap));
            this.lbl_giriskllnadi = new System.Windows.Forms.Label();
            this.txt_kulad = new System.Windows.Forms.TextBox();
            this.lbl_girissifre = new System.Windows.Forms.Label();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_girissfrunuttum = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_giriskllnadi
            // 
            this.lbl_giriskllnadi.AutoSize = true;
            this.lbl_giriskllnadi.Location = new System.Drawing.Point(253, 67);
            this.lbl_giriskllnadi.Name = "lbl_giriskllnadi";
            this.lbl_giriskllnadi.Size = new System.Drawing.Size(77, 16);
            this.lbl_giriskllnadi.TabIndex = 0;
            this.lbl_giriskllnadi.Text = "kullanici adi";
            // 
            // txt_kulad
            // 
            this.txt_kulad.Location = new System.Drawing.Point(369, 67);
            this.txt_kulad.Name = "txt_kulad";
            this.txt_kulad.Size = new System.Drawing.Size(100, 22);
            this.txt_kulad.TabIndex = 0;
            // 
            // lbl_girissifre
            // 
            this.lbl_girissifre.AutoSize = true;
            this.lbl_girissifre.Location = new System.Drawing.Point(298, 124);
            this.lbl_girissifre.Name = "lbl_girissifre";
            this.lbl_girissifre.Size = new System.Drawing.Size(32, 16);
            this.lbl_girissifre.TabIndex = 0;
            this.lbl_girissifre.Text = "sifre";
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(369, 124);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(100, 22);
            this.txt_sifre.TabIndex = 1;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "1398911_correct_mark_success_tick_valid_icon.ico");
            this.ımageList1.Images.SetKeyName(1, "8673525_ic_fluent_person_question_mark_icon.ico");
            this.ımageList1.Images.SetKeyName(2, "2203549_admin_avatar_human_login_user_icon.ico");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::barkodlumarketotomasyon.Properties.Resources._2203549_admin_avatar_human_login_user_icon;
            this.pictureBox1.Location = new System.Drawing.Point(53, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageIndex = 0;
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(384, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "giris yap";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_girissfrunuttum
            // 
            this.btn_girissfrunuttum.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_girissfrunuttum.ImageIndex = 1;
            this.btn_girissfrunuttum.ImageList = this.ımageList1;
            this.btn_girissfrunuttum.Location = new System.Drawing.Point(249, 196);
            this.btn_girissfrunuttum.Name = "btn_girissfrunuttum";
            this.btn_girissfrunuttum.Size = new System.Drawing.Size(89, 43);
            this.btn_girissfrunuttum.TabIndex = 3;
            this.btn_girissfrunuttum.Text = "sifremi unuttum";
            this.btn_girissfrunuttum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_girissfrunuttum.UseVisualStyleBackColor = true;
            this.btn_girissfrunuttum.Click += new System.EventHandler(this.btn_girissfrunuttum_Click);
            // 
            // girisyap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.txt_kulad);
            this.Controls.Add(this.lbl_girissifre);
            this.Controls.Add(this.btn_girissfrunuttum);
            this.Controls.Add(this.lbl_giriskllnadi);
            this.Name = "girisyap";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_giriskllnadi;
        private System.Windows.Forms.TextBox txt_kulad;
        private System.Windows.Forms.Label lbl_girissifre;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.Button btn_girissfrunuttum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList ımageList1;
    }
}

