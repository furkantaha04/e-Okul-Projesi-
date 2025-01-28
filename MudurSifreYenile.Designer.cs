namespace e_Okul_Projesi
{
    partial class MudurSifreYenile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MudurSifreYenile));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMudur = new System.Windows.Forms.Button();
            this.btnKodMudur = new System.Windows.Forms.Button();
            this.txtKod = new System.Windows.Forms.TextBox();
            this.lblKod = new System.Windows.Forms.Label();
            this.maskedMudur = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Geri = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Geri)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.Geri);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(509, 63);
            this.panel1.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.label1.Font = new System.Drawing.Font("Corbel", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(107, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 40);
            this.label1.TabIndex = 24;
            this.label1.Text = "Şifre Yenileme Ekranı";
            // 
            // btnMudur
            // 
            this.btnMudur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.btnMudur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMudur.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMudur.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMudur.Location = new System.Drawing.Point(158, 327);
            this.btnMudur.Name = "btnMudur";
            this.btnMudur.Size = new System.Drawing.Size(162, 45);
            this.btnMudur.TabIndex = 32;
            this.btnMudur.Text = "Güncelle";
            this.btnMudur.UseVisualStyleBackColor = false;
            this.btnMudur.Click += new System.EventHandler(this.btnMudur_Click);
            // 
            // btnKodMudur
            // 
            this.btnKodMudur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.btnKodMudur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKodMudur.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKodMudur.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKodMudur.Location = new System.Drawing.Point(331, 277);
            this.btnKodMudur.Name = "btnKodMudur";
            this.btnKodMudur.Size = new System.Drawing.Size(97, 41);
            this.btnKodMudur.TabIndex = 31;
            this.btnKodMudur.Text = "Kod Al";
            this.btnKodMudur.UseVisualStyleBackColor = false;
            this.btnKodMudur.Click += new System.EventHandler(this.btnKodMudur_Click);
            // 
            // txtKod
            // 
            this.txtKod.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtKod.Location = new System.Drawing.Point(173, 279);
            this.txtKod.Multiline = true;
            this.txtKod.Name = "txtKod";
            this.txtKod.Size = new System.Drawing.Size(143, 31);
            this.txtKod.TabIndex = 29;
            this.txtKod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MudurSifreYenile_KeyDown);
            // 
            // lblKod
            // 
            this.lblKod.AutoSize = true;
            this.lblKod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.lblKod.Font = new System.Drawing.Font("Segoe Script", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKod.ForeColor = System.Drawing.SystemColors.Control;
            this.lblKod.Location = new System.Drawing.Point(68, 269);
            this.lblKod.Name = "lblKod";
            this.lblKod.Size = new System.Drawing.Size(97, 50);
            this.lblKod.TabIndex = 30;
            this.lblKod.Text = "KOD";
            // 
            // maskedMudur
            // 
            this.maskedMudur.BackColor = System.Drawing.Color.Azure;
            this.maskedMudur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedMudur.Location = new System.Drawing.Point(176, 230);
            this.maskedMudur.Mask = "00000000000";
            this.maskedMudur.Name = "maskedMudur";
            this.maskedMudur.Size = new System.Drawing.Size(173, 22);
            this.maskedMudur.TabIndex = 27;
            this.maskedMudur.ValidatingType = typeof(int);
            this.maskedMudur.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MudurSifreYenile_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.label2.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(84, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 28);
            this.label2.TabIndex = 28;
            this.label2.Text = "TC No :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(209, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // Geri
            // 
            this.Geri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Geri.Image = global::e_Okul_Projesi.Properties.Resources.GeriSiyah;
            this.Geri.Location = new System.Drawing.Point(3, 3);
            this.Geri.Name = "Geri";
            this.Geri.Size = new System.Drawing.Size(69, 46);
            this.Geri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Geri.TabIndex = 87;
            this.Geri.TabStop = false;
            this.Geri.Click += new System.EventHandler(this.Geri_Click);
            this.Geri.MouseEnter += new System.EventHandler(this.Geri_MouseEnter);
            this.Geri.MouseLeave += new System.EventHandler(this.Geri_MouseLeave);
            // 
            // MudurSifreYenile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(509, 395);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnMudur);
            this.Controls.Add(this.btnKodMudur);
            this.Controls.Add(this.txtKod);
            this.Controls.Add(this.lblKod);
            this.Controls.Add(this.maskedMudur);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MudurSifreYenile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MudurSifreYenile";
            this.Load += new System.EventHandler(this.MudurSifreYenile_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MudurSifreYenile_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Geri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMudur;
        private System.Windows.Forms.Button btnKodMudur;
        private System.Windows.Forms.TextBox txtKod;
        private System.Windows.Forms.Label lblKod;
        private System.Windows.Forms.MaskedTextBox maskedMudur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Geri;
    }
}