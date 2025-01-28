namespace e_Okul_Projesi
{
    partial class FrmÖgretmenGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmÖgretmenGiris));
            this.label1 = new System.Windows.Forms.Label();
            this.btnKodOgrt = new System.Windows.Forms.Button();
            this.txtKod = new System.Windows.Forms.TextBox();
            this.lblKod = new System.Windows.Forms.Label();
            this.btnOgretmenDetay = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.maskedOgrt = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUyarı = new System.Windows.Forms.Label();
            this.lnkSifreOgrt = new System.Windows.Forms.LinkLabel();
            this.Geri = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Geri)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(36, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = " e-Okul Öğretmen Girişi";
            // 
            // btnKodOgrt
            // 
            this.btnKodOgrt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.btnKodOgrt.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKodOgrt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKodOgrt.Location = new System.Drawing.Point(342, 449);
            this.btnKodOgrt.Name = "btnKodOgrt";
            this.btnKodOgrt.Size = new System.Drawing.Size(83, 50);
            this.btnKodOgrt.TabIndex = 19;
            this.btnKodOgrt.Text = "Kod Al";
            this.btnKodOgrt.UseVisualStyleBackColor = false;
            this.btnKodOgrt.Click += new System.EventHandler(this.btnKodOgrt_Click);
            // 
            // txtKod
            // 
            this.txtKod.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtKod.Location = new System.Drawing.Point(162, 465);
            this.txtKod.Multiline = true;
            this.txtKod.Name = "txtKod";
            this.txtKod.Size = new System.Drawing.Size(174, 26);
            this.txtKod.TabIndex = 3;
            // 
            // lblKod
            // 
            this.lblKod.AutoSize = true;
            this.lblKod.Font = new System.Drawing.Font("Segoe Script", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKod.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblKod.Location = new System.Drawing.Point(57, 455);
            this.lblKod.Name = "lblKod";
            this.lblKod.Size = new System.Drawing.Size(97, 50);
            this.lblKod.TabIndex = 17;
            this.lblKod.Text = "KOD";
            // 
            // btnOgretmenDetay
            // 
            this.btnOgretmenDetay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.btnOgretmenDetay.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgretmenDetay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOgretmenDetay.Location = new System.Drawing.Point(116, 521);
            this.btnOgretmenDetay.Name = "btnOgretmenDetay";
            this.btnOgretmenDetay.Size = new System.Drawing.Size(240, 45);
            this.btnOgretmenDetay.TabIndex = 16;
            this.btnOgretmenDetay.Text = "Giriş";
            this.btnOgretmenDetay.UseVisualStyleBackColor = false;
            this.btnOgretmenDetay.Click += new System.EventHandler(this.btnOgretmenDetay_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(69, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 35);
            this.label3.TabIndex = 15;
            this.label3.Text = "Şifre :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtSifre.Location = new System.Drawing.Point(162, 385);
            this.txtSifre.Multiline = true;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(168, 23);
            this.txtSifre.TabIndex = 2;
            this.txtSifre.TextChanged += new System.EventHandler(this.txtSifre_TextChanged);
            // 
            // maskedOgrt
            // 
            this.maskedOgrt.BackColor = System.Drawing.Color.White;
            this.maskedOgrt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedOgrt.Location = new System.Drawing.Point(162, 341);
            this.maskedOgrt.Mask = "00000000000";
            this.maskedOgrt.Name = "maskedOgrt";
            this.maskedOgrt.Size = new System.Drawing.Size(173, 22);
            this.maskedOgrt.TabIndex = 1;
            this.maskedOgrt.ValidatingType = typeof(int);
            this.maskedOgrt.TextChanged += new System.EventHandler(this.maskedTextBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(54, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 35);
            this.label2.TabIndex = 12;
            this.label2.Text = "TC No :";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::e_Okul_Projesi.Properties.Resources.eye;
            this.pictureBox3.Location = new System.Drawing.Point(342, 372);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(69, 47);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseDown);
            this.pictureBox3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseUp);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(162, 121);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(168, 144);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::e_Okul_Projesi.Properties.Resources.turkiye_cumhuriyeti_milli_egitim_bakanligi_logo_clipart_original;
            this.pictureBox1.Location = new System.Drawing.Point(336, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblUyarı
            // 
            this.lblUyarı.AutoSize = true;
            this.lblUyarı.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUyarı.ForeColor = System.Drawing.Color.Red;
            this.lblUyarı.Location = new System.Drawing.Point(158, 283);
            this.lblUyarı.Name = "lblUyarı";
            this.lblUyarı.Size = new System.Drawing.Size(176, 21);
            this.lblUyarı.TabIndex = 21;
            this.lblUyarı.Text = "TC no Yada Şifre yanlış";
            this.lblUyarı.Visible = false;
            // 
            // lnkSifreOgrt
            // 
            this.lnkSifreOgrt.AutoSize = true;
            this.lnkSifreOgrt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkSifreOgrt.LinkColor = System.Drawing.SystemColors.HotTrack;
            this.lnkSifreOgrt.Location = new System.Drawing.Point(231, 411);
            this.lnkSifreOgrt.Name = "lnkSifreOgrt";
            this.lnkSifreOgrt.Size = new System.Drawing.Size(99, 16);
            this.lnkSifreOgrt.TabIndex = 22;
            this.lnkSifreOgrt.TabStop = true;
            this.lnkSifreOgrt.Text = "Şifremi Unuttum";
            this.lnkSifreOgrt.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSifreOgrt_LinkClicked);
            this.lnkSifreOgrt.Click += new System.EventHandler(this.lnkSifreOgrt_Click);
            // 
            // Geri
            // 
            this.Geri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Geri.Image = global::e_Okul_Projesi.Properties.Resources.GeriSiyah;
            this.Geri.Location = new System.Drawing.Point(5, 11);
            this.Geri.Name = "Geri";
            this.Geri.Size = new System.Drawing.Size(73, 44);
            this.Geri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Geri.TabIndex = 25;
            this.Geri.TabStop = false;
            this.Geri.Click += new System.EventHandler(this.Geri_Click);
            this.Geri.MouseEnter += new System.EventHandler(this.Geri_MouseEnter);
            this.Geri.MouseLeave += new System.EventHandler(this.Geri_MouseLeave);
            // 
            // FrmÖgretmenGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(465, 611);
            this.Controls.Add(this.Geri);
            this.Controls.Add(this.lnkSifreOgrt);
            this.Controls.Add(this.lblUyarı);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnKodOgrt);
            this.Controls.Add(this.txtKod);
            this.Controls.Add(this.lblKod);
            this.Controls.Add(this.btnOgretmenDetay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.maskedOgrt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmÖgretmenGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmÖgretmenGiris";
            this.Load += new System.EventHandler(this.FrmÖgretmenGiris_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmÖgretmenGiris_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Geri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKodOgrt;
        private System.Windows.Forms.TextBox txtKod;
        private System.Windows.Forms.Label lblKod;
        private System.Windows.Forms.Button btnOgretmenDetay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.MaskedTextBox maskedOgrt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblUyarı;
        private System.Windows.Forms.LinkLabel lnkSifreOgrt;
        private System.Windows.Forms.PictureBox Geri;
    }
}