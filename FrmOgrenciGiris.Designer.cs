namespace e_Okul_Projesi
{
    partial class FrmOgrenciGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOgrenciGiris));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mskTc = new System.Windows.Forms.MaskedTextBox();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnÖgrenciDetay = new System.Windows.Forms.Button();
            this.lblKod = new System.Windows.Forms.Label();
            this.txtKod = new System.Windows.Forms.TextBox();
            this.btnKod = new System.Windows.Forms.Button();
            this.Geri = new System.Windows.Forms.PictureBox();
            this.lblUyarı = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Geri)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(21, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = " e-Okul Öğrenci Girisi";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::e_Okul_Projesi.Properties.Resources.turkiye_cumhuriyeti_milli_egitim_bakanligi_logo_clipart_original;
            this.pictureBox1.Location = new System.Drawing.Point(318, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(133, 148);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(195, 145);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(46, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "TC No :";
            // 
            // mskTc
            // 
            this.mskTc.BackColor = System.Drawing.Color.White;
            this.mskTc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskTc.Location = new System.Drawing.Point(160, 356);
            this.mskTc.Mask = "00000000000";
            this.mskTc.Name = "mskTc";
            this.mskTc.Size = new System.Drawing.Size(191, 22);
            this.mskTc.TabIndex = 1;
            this.mskTc.ValidatingType = typeof(int);
            this.mskTc.TextChanged += new System.EventHandler(this.mskTc_TextChanged);
            // 
            // txtNo
            // 
            this.txtNo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtNo.Location = new System.Drawing.Point(159, 404);
            this.txtNo.Multiline = true;
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(191, 23);
            this.txtNo.TabIndex = 2;
            this.txtNo.TextChanged += new System.EventHandler(this.txtNo_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(21, 393);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 37);
            this.label3.TabIndex = 7;
            this.label3.Text = "Numara :";
            // 
            // btnÖgrenciDetay
            // 
            this.btnÖgrenciDetay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.btnÖgrenciDetay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnÖgrenciDetay.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnÖgrenciDetay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnÖgrenciDetay.Location = new System.Drawing.Point(103, 524);
            this.btnÖgrenciDetay.Name = "btnÖgrenciDetay";
            this.btnÖgrenciDetay.Size = new System.Drawing.Size(261, 43);
            this.btnÖgrenciDetay.TabIndex = 4;
            this.btnÖgrenciDetay.Text = "Giriş";
            this.btnÖgrenciDetay.UseVisualStyleBackColor = false;
            this.btnÖgrenciDetay.Click += new System.EventHandler(this.btnÖgrenciDetay_Click);
            // 
            // lblKod
            // 
            this.lblKod.AutoSize = true;
            this.lblKod.Font = new System.Drawing.Font("Segoe Script", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKod.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblKod.Location = new System.Drawing.Point(44, 440);
            this.lblKod.Name = "lblKod";
            this.lblKod.Size = new System.Drawing.Size(97, 50);
            this.lblKod.TabIndex = 9;
            this.lblKod.Text = "KOD";
            // 
            // txtKod
            // 
            this.txtKod.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtKod.Location = new System.Drawing.Point(156, 450);
            this.txtKod.Multiline = true;
            this.txtKod.Name = "txtKod";
            this.txtKod.Size = new System.Drawing.Size(180, 31);
            this.txtKod.TabIndex = 3;
            // 
            // btnKod
            // 
            this.btnKod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.btnKod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKod.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKod.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKod.Location = new System.Drawing.Point(345, 450);
            this.btnKod.Name = "btnKod";
            this.btnKod.Size = new System.Drawing.Size(84, 35);
            this.btnKod.TabIndex = 11;
            this.btnKod.Text = "Kod Al";
            this.btnKod.UseVisualStyleBackColor = false;
            this.btnKod.Click += new System.EventHandler(this.btnKod_Click);
            // 
            // Geri
            // 
            this.Geri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Geri.Image = global::e_Okul_Projesi.Properties.Resources.GeriSiyah;
            this.Geri.Location = new System.Drawing.Point(2, 12);
            this.Geri.Name = "Geri";
            this.Geri.Size = new System.Drawing.Size(73, 44);
            this.Geri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Geri.TabIndex = 12;
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
            this.lblUyarı.Location = new System.Drawing.Point(129, 310);
            this.lblUyarı.Name = "lblUyarı";
            this.lblUyarı.Size = new System.Drawing.Size(200, 21);
            this.lblUyarı.TabIndex = 22;
            this.lblUyarı.Text = "TC no Yada Numara yanlış";
            this.lblUyarı.Visible = false;
            // 
            // FrmOgrenciGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(465, 611);
            this.Controls.Add(this.lblUyarı);
            this.Controls.Add(this.Geri);
            this.Controls.Add(this.btnKod);
            this.Controls.Add(this.txtKod);
            this.Controls.Add(this.lblKod);
            this.Controls.Add(this.btnÖgrenciDetay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNo);
            this.Controls.Add(this.mskTc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmOgrenciGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmOgrenciGiris";
            this.Load += new System.EventHandler(this.FrmOgrenciGiris_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmOgrenciGiris_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Geri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskTc;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnÖgrenciDetay;
        private System.Windows.Forms.Label lblKod;
        private System.Windows.Forms.TextBox txtKod;
        private System.Windows.Forms.Button btnKod;
        private System.Windows.Forms.PictureBox Geri;
        private System.Windows.Forms.Label lblUyarı;
    }
}