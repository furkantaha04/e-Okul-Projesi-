namespace e_Okul_Projesi
{
    partial class MudurSifre
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMudurGuncelle = new System.Windows.Forms.Button();
            this.txtsifreonay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtYenisifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Geri = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Geri)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.Geri);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(586, 63);
            this.panel1.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.label3.Font = new System.Drawing.Font("Corbel", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(172, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 40);
            this.label3.TabIndex = 24;
            this.label3.Text = "Şifreni Oluştur";
            // 
            // btnMudurGuncelle
            // 
            this.btnMudurGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.btnMudurGuncelle.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMudurGuncelle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMudurGuncelle.Location = new System.Drawing.Point(197, 210);
            this.btnMudurGuncelle.Name = "btnMudurGuncelle";
            this.btnMudurGuncelle.Size = new System.Drawing.Size(184, 45);
            this.btnMudurGuncelle.TabIndex = 33;
            this.btnMudurGuncelle.Text = "Onayla";
            this.btnMudurGuncelle.UseVisualStyleBackColor = false;
            this.btnMudurGuncelle.Click += new System.EventHandler(this.btnMudurGuncelle_Click);
            // 
            // txtsifreonay
            // 
            this.txtsifreonay.BackColor = System.Drawing.Color.White;
            this.txtsifreonay.Location = new System.Drawing.Point(236, 150);
            this.txtsifreonay.Multiline = true;
            this.txtsifreonay.Name = "txtsifreonay";
            this.txtsifreonay.PasswordChar = '*';
            this.txtsifreonay.Size = new System.Drawing.Size(184, 31);
            this.txtsifreonay.TabIndex = 32;
            this.txtsifreonay.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtYenisifre_KeyDown);
            this.txtsifreonay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsifreonay_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.label1.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(101, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 28);
            this.label1.TabIndex = 31;
            this.label1.Text = "Şifre Onay :";
            // 
            // txtYenisifre
            // 
            this.txtYenisifre.BackColor = System.Drawing.Color.White;
            this.txtYenisifre.Location = new System.Drawing.Point(234, 101);
            this.txtYenisifre.Multiline = true;
            this.txtYenisifre.Name = "txtYenisifre";
            this.txtYenisifre.PasswordChar = '*';
            this.txtYenisifre.Size = new System.Drawing.Size(184, 31);
            this.txtYenisifre.TabIndex = 30;
            this.txtYenisifre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtYenisifre_KeyDown);
            this.txtYenisifre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsifreonay_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.label2.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(109, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 28);
            this.label2.TabIndex = 29;
            this.label2.Text = "Yeni Şifre :";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::e_Okul_Projesi.Properties.Resources.eye;
            this.pictureBox3.Location = new System.Drawing.Point(437, 124);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 33);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 35;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseDown);
            this.pictureBox3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseUp);
            // 
            // Geri
            // 
            this.Geri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Geri.Image = global::e_Okul_Projesi.Properties.Resources.GeriSiyah;
            this.Geri.Location = new System.Drawing.Point(3, 3);
            this.Geri.Name = "Geri";
            this.Geri.Size = new System.Drawing.Size(69, 46);
            this.Geri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Geri.TabIndex = 86;
            this.Geri.TabStop = false;
            this.Geri.Click += new System.EventHandler(this.Geri_Click);
            this.Geri.MouseEnter += new System.EventHandler(this.Geri_MouseEnter);
            this.Geri.MouseLeave += new System.EventHandler(this.Geri_MouseLeave);
            // 
            // MudurSifre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(586, 281);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnMudurGuncelle);
            this.Controls.Add(this.txtsifreonay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtYenisifre);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MudurSifre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MudurSifre";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MudurSifre_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Geri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMudurGuncelle;
        private System.Windows.Forms.TextBox txtsifreonay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYenisifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Geri;
    }
}