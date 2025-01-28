namespace e_Okul_Projesi
{
    partial class FrmMudurGirisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMudurGirisi));
            this.mskMudur = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMudurDetay = new System.Windows.Forms.Button();
            this.btnKodMud = new System.Windows.Forms.Button();
            this.txtKod = new System.Windows.Forms.TextBox();
            this.lblKod = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lnkSifreMudur = new System.Windows.Forms.LinkLabel();
            this.Geri = new System.Windows.Forms.PictureBox();
            this.lblUyarı = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Geri)).BeginInit();
            this.SuspendLayout();
            // 
            // mskMudur
            // 
            this.mskMudur.BackColor = System.Drawing.Color.Azure;
            this.mskMudur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskMudur.Location = new System.Drawing.Point(121, 332);
            this.mskMudur.Mask = "00000000000";
            this.mskMudur.Name = "mskMudur";
            this.mskMudur.Size = new System.Drawing.Size(205, 22);
            this.mskMudur.TabIndex = 1;
            this.mskMudur.ValidatingType = typeof(int);
            this.mskMudur.TextChanged += new System.EventHandler(this.mskMudur_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(13, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 35);
            this.label2.TabIndex = 6;
            this.label2.Text = "TC No :";
            // 
            // btnMudurDetay
            // 
            this.btnMudurDetay.BackColor = System.Drawing.Color.SlateGray;
            this.btnMudurDetay.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMudurDetay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMudurDetay.Location = new System.Drawing.Point(94, 528);
            this.btnMudurDetay.Name = "btnMudurDetay";
            this.btnMudurDetay.Size = new System.Drawing.Size(256, 52);
            this.btnMudurDetay.TabIndex = 4;
            this.btnMudurDetay.Text = "Giriş";
            this.btnMudurDetay.UseVisualStyleBackColor = false;
            this.btnMudurDetay.Click += new System.EventHandler(this.btnMudurDetay_Click);
            // 
            // btnKodMud
            // 
            this.btnKodMud.BackColor = System.Drawing.Color.Gray;
            this.btnKodMud.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKodMud.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKodMud.Location = new System.Drawing.Point(345, 448);
            this.btnKodMud.Name = "btnKodMud";
            this.btnKodMud.Size = new System.Drawing.Size(102, 48);
            this.btnKodMud.TabIndex = 14;
            this.btnKodMud.Text = "Kod Al";
            this.btnKodMud.UseVisualStyleBackColor = false;
            this.btnKodMud.Click += new System.EventHandler(this.btnKodMud_Click);
            // 
            // txtKod
            // 
            this.txtKod.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtKod.Location = new System.Drawing.Point(121, 456);
            this.txtKod.Multiline = true;
            this.txtKod.Name = "txtKod";
            this.txtKod.Size = new System.Drawing.Size(205, 32);
            this.txtKod.TabIndex = 3;
            // 
            // lblKod
            // 
            this.lblKod.AutoSize = true;
            this.lblKod.Font = new System.Drawing.Font("Segoe Script", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKod.Location = new System.Drawing.Point(12, 456);
            this.lblKod.Name = "lblKod";
            this.lblKod.Size = new System.Drawing.Size(97, 50);
            this.lblKod.TabIndex = 12;
            this.lblKod.Text = "KOD";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::e_Okul_Projesi.Properties.Resources.turkiye_cumhuriyeti_milli_egitim_bakanligi_logo_clipart_original;
            this.pictureBox1.Location = new System.Drawing.Point(318, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(121, 113);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(168, 158);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(30, 383);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 35);
            this.label3.TabIndex = 18;
            this.label3.Text = "Şifre :";
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtSifre.Location = new System.Drawing.Point(121, 392);
            this.txtSifre.Multiline = true;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(205, 26);
            this.txtSifre.TabIndex = 2;
            this.txtSifre.TextChanged += new System.EventHandler(this.txtSifre_TextChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::e_Okul_Projesi.Properties.Resources.eye;
            this.pictureBox3.Location = new System.Drawing.Point(345, 386);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(54, 42);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseDown);
            this.pictureBox3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseUp);
            // 
            // lnkSifreMudur
            // 
            this.lnkSifreMudur.AutoSize = true;
            this.lnkSifreMudur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkSifreMudur.LinkColor = System.Drawing.SystemColors.HotTrack;
            this.lnkSifreMudur.Location = new System.Drawing.Point(227, 422);
            this.lnkSifreMudur.Name = "lnkSifreMudur";
            this.lnkSifreMudur.Size = new System.Drawing.Size(99, 16);
            this.lnkSifreMudur.TabIndex = 23;
            this.lnkSifreMudur.TabStop = true;
            this.lnkSifreMudur.Text = "Şifremi Unuttum";
            this.lnkSifreMudur.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSifreMudur_LinkClicked);
            // 
            // Geri
            // 
            this.Geri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Geri.Image = global::e_Okul_Projesi.Properties.Resources.GeriSiyah;
            this.Geri.Location = new System.Drawing.Point(3, 8);
            this.Geri.Name = "Geri";
            this.Geri.Size = new System.Drawing.Size(73, 44);
            this.Geri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Geri.TabIndex = 24;
            this.Geri.TabStop = false;
            this.Geri.Click += new System.EventHandler(this.Geri_Click);
            this.Geri.MouseEnter += new System.EventHandler(this.Geri_MouseEnter);
            this.Geri.MouseLeave += new System.EventHandler(this.Geri_MouseLeave);
            // 
            // lblUyarı
            // 
            this.lblUyarı.AutoSize = true;
            this.lblUyarı.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUyarı.ForeColor = System.Drawing.Color.Red;
            this.lblUyarı.Location = new System.Drawing.Point(117, 294);
            this.lblUyarı.Name = "lblUyarı";
            this.lblUyarı.Size = new System.Drawing.Size(176, 21);
            this.lblUyarı.TabIndex = 25;
            this.lblUyarı.Text = "TC no Yada Şifre yanlış";
            this.lblUyarı.Visible = false;
            // 
            // FrmMudurGirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(465, 611);
            this.Controls.Add(this.lblUyarı);
            this.Controls.Add(this.Geri);
            this.Controls.Add(this.lnkSifreMudur);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnKodMud);
            this.Controls.Add(this.txtKod);
            this.Controls.Add(this.lblKod);
            this.Controls.Add(this.btnMudurDetay);
            this.Controls.Add(this.mskMudur);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmMudurGirisi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMudurGirisi";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMudurGirisi_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Geri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox mskMudur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMudurDetay;
        private System.Windows.Forms.Button btnKodMud;
        private System.Windows.Forms.TextBox txtKod;
        private System.Windows.Forms.Label lblKod;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.LinkLabel lnkSifreMudur;
        private System.Windows.Forms.PictureBox Geri;
        private System.Windows.Forms.Label lblUyarı;
    }
}