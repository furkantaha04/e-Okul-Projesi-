namespace e_Okul_Projesi
{
    partial class FrmÖgretmenDetay
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmÖgretmenDetay));
            this.grpOgrtBilgi = new System.Windows.Forms.GroupBox();
            this.lblogrtAdSoyad = new System.Windows.Forms.Label();
            this.lblogrtTcNo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpİletisim = new System.Windows.Forms.GroupBox();
            this.dataMesaj = new System.Windows.Forms.DataGridView();
            this.btnsil = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnNotİŞLEMLERİ = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnDevamsızlık = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picturKapatma = new System.Windows.Forms.PictureBox();
            this.grpOgrtBilgi.SuspendLayout();
            this.grpİletisim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMesaj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturKapatma)).BeginInit();
            this.SuspendLayout();
            // 
            // grpOgrtBilgi
            // 
            this.grpOgrtBilgi.Controls.Add(this.lblogrtAdSoyad);
            this.grpOgrtBilgi.Controls.Add(this.lblogrtTcNo);
            this.grpOgrtBilgi.Controls.Add(this.label1);
            this.grpOgrtBilgi.Controls.Add(this.label2);
            this.grpOgrtBilgi.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOgrtBilgi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpOgrtBilgi.Location = new System.Drawing.Point(13, 23);
            this.grpOgrtBilgi.Name = "grpOgrtBilgi";
            this.grpOgrtBilgi.Size = new System.Drawing.Size(422, 239);
            this.grpOgrtBilgi.TabIndex = 1;
            this.grpOgrtBilgi.TabStop = false;
            this.grpOgrtBilgi.Text = "Öğretmen Bilgileri";
            // 
            // lblogrtAdSoyad
            // 
            this.lblogrtAdSoyad.AutoSize = true;
            this.lblogrtAdSoyad.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblogrtAdSoyad.Location = new System.Drawing.Point(145, 124);
            this.lblogrtAdSoyad.Name = "lblogrtAdSoyad";
            this.lblogrtAdSoyad.Size = new System.Drawing.Size(139, 29);
            this.lblogrtAdSoyad.TabIndex = 17;
            this.lblogrtAdSoyad.Text = "NULL NULL";
            // 
            // lblogrtTcNo
            // 
            this.lblogrtTcNo.AutoSize = true;
            this.lblogrtTcNo.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblogrtTcNo.Location = new System.Drawing.Point(132, 85);
            this.lblogrtTcNo.Name = "lblogrtTcNo";
            this.lblogrtTcNo.Size = new System.Drawing.Size(167, 29);
            this.lblogrtTcNo.TabIndex = 16;
            this.lblogrtTcNo.Text = "00000000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ad SoyAd :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "TC No :";
            // 
            // grpİletisim
            // 
            this.grpİletisim.Controls.Add(this.dataMesaj);
            this.grpİletisim.Controls.Add(this.btnsil);
            this.grpİletisim.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpİletisim.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpİletisim.Location = new System.Drawing.Point(13, 268);
            this.grpİletisim.Name = "grpİletisim";
            this.grpİletisim.Size = new System.Drawing.Size(1283, 482);
            this.grpİletisim.TabIndex = 20;
            this.grpİletisim.TabStop = false;
            this.grpİletisim.Text = "Öğrenci Mesajları";
            // 
            // dataMesaj
            // 
            this.dataMesaj.AllowUserToAddRows = false;
            this.dataMesaj.AllowUserToDeleteRows = false;
            this.dataMesaj.AllowUserToResizeColumns = false;
            this.dataMesaj.AllowUserToResizeRows = false;
            this.dataMesaj.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataMesaj.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.dataMesaj.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataMesaj.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataMesaj.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataMesaj.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataMesaj.ColumnHeadersHeight = 50;
            this.dataMesaj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataMesaj.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataMesaj.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataMesaj.Enabled = false;
            this.dataMesaj.EnableHeadersVisualStyles = false;
            this.dataMesaj.GridColor = System.Drawing.Color.White;
            this.dataMesaj.Location = new System.Drawing.Point(9, 35);
            this.dataMesaj.Name = "dataMesaj";
            this.dataMesaj.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataMesaj.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataMesaj.RowHeadersVisible = false;
            this.dataMesaj.RowHeadersWidth = 51;
            this.dataMesaj.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataMesaj.RowTemplate.Height = 100;
            this.dataMesaj.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataMesaj.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataMesaj.Size = new System.Drawing.Size(1265, 393);
            this.dataMesaj.TabIndex = 25;
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.btnsil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsil.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnsil.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsil.Location = new System.Drawing.Point(3, 434);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(1277, 45);
            this.btnsil.TabIndex = 24;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(533, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(307, 61);
            this.button1.TabIndex = 21;
            this.button1.Text = "KURS İŞLEMLERİ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNotİŞLEMLERİ
            // 
            this.btnNotİŞLEMLERİ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.btnNotİŞLEMLERİ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNotİŞLEMLERİ.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNotİŞLEMLERİ.ForeColor = System.Drawing.Color.Transparent;
            this.btnNotİŞLEMLERİ.Location = new System.Drawing.Point(533, 166);
            this.btnNotİŞLEMLERİ.Name = "btnNotİŞLEMLERİ";
            this.btnNotİŞLEMLERİ.Size = new System.Drawing.Size(307, 61);
            this.btnNotİŞLEMLERİ.TabIndex = 22;
            this.btnNotİŞLEMLERİ.Text = "NOT İŞLEMLERİ";
            this.btnNotİŞLEMLERİ.UseVisualStyleBackColor = false;
            this.btnNotİŞLEMLERİ.Click += new System.EventHandler(this.btnNotİŞLEMLERİ_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.Location = new System.Drawing.Point(980, 76);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(307, 61);
            this.button3.TabIndex = 23;
            this.button3.Text = "ÖĞRENCİLER";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnDevamsızlık
            // 
            this.btnDevamsızlık.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.btnDevamsızlık.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDevamsızlık.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDevamsızlık.ForeColor = System.Drawing.Color.Transparent;
            this.btnDevamsızlık.Location = new System.Drawing.Point(980, 161);
            this.btnDevamsızlık.Name = "btnDevamsızlık";
            this.btnDevamsızlık.Size = new System.Drawing.Size(307, 61);
            this.btnDevamsızlık.TabIndex = 24;
            this.btnDevamsızlık.Text = "DEVAMSIZLIK İŞLEMLERİ";
            this.btnDevamsızlık.UseVisualStyleBackColor = false;
            this.btnDevamsızlık.Click += new System.EventHandler(this.btnDevamsızlık_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(888, 155);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(86, 72);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 30;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(888, 76);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(86, 61);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 29;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(441, 169);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(86, 61);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(441, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // picturKapatma
            // 
            this.picturKapatma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picturKapatma.Image = global::e_Okul_Projesi.Properties.Resources.KapatmaLeave;
            this.picturKapatma.Location = new System.Drawing.Point(1220, 12);
            this.picturKapatma.Name = "picturKapatma";
            this.picturKapatma.Size = new System.Drawing.Size(67, 50);
            this.picturKapatma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturKapatma.TabIndex = 36;
            this.picturKapatma.TabStop = false;
            this.picturKapatma.Click += new System.EventHandler(this.picturKapatma_Click);
            this.picturKapatma.MouseEnter += new System.EventHandler(this.picturKapatma_MouseEnter);
            this.picturKapatma.MouseLeave += new System.EventHandler(this.picturKapatma_MouseLeave);
            // 
            // FrmÖgretmenDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1321, 774);
            this.Controls.Add(this.picturKapatma);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDevamsızlık);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnNotİŞLEMLERİ);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grpİletisim);
            this.Controls.Add(this.grpOgrtBilgi);
            this.ForeColor = System.Drawing.Color.Honeydew;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmÖgretmenDetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmÖgretmenDetay";
            this.Load += new System.EventHandler(this.FrmÖgretmenDetay_Load);
            this.grpOgrtBilgi.ResumeLayout(false);
            this.grpOgrtBilgi.PerformLayout();
            this.grpİletisim.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataMesaj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturKapatma)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOgrtBilgi;
        private System.Windows.Forms.Label lblogrtAdSoyad;
        private System.Windows.Forms.Label lblogrtTcNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpİletisim;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnNotİŞLEMLERİ;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnDevamsızlık;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.DataGridView dataMesaj;
        private System.Windows.Forms.PictureBox picturKapatma;
    }
}