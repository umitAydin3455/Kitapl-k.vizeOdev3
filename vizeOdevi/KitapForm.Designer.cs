namespace vizeOdevi
{
    partial class KitapForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnKitapEkle = new System.Windows.Forms.Button();
            this.kitapAdi = new System.Windows.Forms.TextBox();
            this.kitapYazari = new System.Windows.Forms.TextBox();
            this.yayini = new System.Windows.Forms.TextBox();
            this.kitapCikisTarihi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dGVKitapListesi = new System.Windows.Forms.DataGridView();
            this.bntKitapSil = new System.Windows.Forms.Button();
            this.btnKitapSec = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVKitapListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1027, 62);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "KİTAP YÖNETİMİ";
            // 
            // btnKitapEkle
            // 
            this.btnKitapEkle.Location = new System.Drawing.Point(47, 437);
            this.btnKitapEkle.Name = "btnKitapEkle";
            this.btnKitapEkle.Size = new System.Drawing.Size(182, 61);
            this.btnKitapEkle.TabIndex = 3;
            this.btnKitapEkle.Text = "KİTAP EKLE";
            this.btnKitapEkle.UseVisualStyleBackColor = true;
            this.btnKitapEkle.Click += new System.EventHandler(this.btnKitapEkle_Click);
            // 
            // kitapAdi
            // 
            this.kitapAdi.Location = new System.Drawing.Point(48, 156);
            this.kitapAdi.Name = "kitapAdi";
            this.kitapAdi.Size = new System.Drawing.Size(240, 22);
            this.kitapAdi.TabIndex = 4;
            // 
            // kitapYazari
            // 
            this.kitapYazari.Location = new System.Drawing.Point(48, 216);
            this.kitapYazari.Name = "kitapYazari";
            this.kitapYazari.Size = new System.Drawing.Size(240, 22);
            this.kitapYazari.TabIndex = 5;
            // 
            // yayini
            // 
            this.yayini.Location = new System.Drawing.Point(48, 290);
            this.yayini.Name = "yayini";
            this.yayini.Size = new System.Drawing.Size(240, 22);
            this.yayini.TabIndex = 6;
            // 
            // kitapCikisTarihi
            // 
            this.kitapCikisTarihi.Location = new System.Drawing.Point(48, 362);
            this.kitapCikisTarihi.Name = "kitapCikisTarihi";
            this.kitapCikisTarihi.Size = new System.Drawing.Size(240, 22);
            this.kitapCikisTarihi.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Kitap Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Kitap Yazarı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Yayın :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Çıkış Tarihi";
            // 
            // dGVKitapListesi
            // 
            this.dGVKitapListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVKitapListesi.Location = new System.Drawing.Point(319, 68);
            this.dGVKitapListesi.Name = "dGVKitapListesi";
            this.dGVKitapListesi.RowHeadersWidth = 51;
            this.dGVKitapListesi.RowTemplate.Height = 24;
            this.dGVKitapListesi.Size = new System.Drawing.Size(696, 563);
            this.dGVKitapListesi.TabIndex = 12;
            // 
            // bntKitapSil
            // 
            this.bntKitapSil.Location = new System.Drawing.Point(235, 437);
            this.bntKitapSil.Name = "bntKitapSil";
            this.bntKitapSil.Size = new System.Drawing.Size(53, 61);
            this.bntKitapSil.TabIndex = 13;
            this.bntKitapSil.Text = "SİL";
            this.bntKitapSil.UseVisualStyleBackColor = true;
            this.bntKitapSil.Click += new System.EventHandler(this.bntKitapSil_Click);
            // 
            // btnKitapSec
            // 
            this.btnKitapSec.Location = new System.Drawing.Point(152, 559);
            this.btnKitapSec.Name = "btnKitapSec";
            this.btnKitapSec.Size = new System.Drawing.Size(136, 23);
            this.btnKitapSec.TabIndex = 0;
            this.btnKitapSec.Text = "Kitap Seç";
            // 
            // KitapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 643);
            this.ControlBox = false;
            this.Controls.Add(this.btnKitapSec);
            this.Controls.Add(this.bntKitapSil);
            this.Controls.Add(this.dGVKitapListesi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kitapCikisTarihi);
            this.Controls.Add(this.yayini);
            this.Controls.Add(this.kitapYazari);
            this.Controls.Add(this.kitapAdi);
            this.Controls.Add(this.btnKitapEkle);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "KitapForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVKitapListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKitapEkle;
        private System.Windows.Forms.TextBox kitapAdi;
        private System.Windows.Forms.TextBox kitapYazari;
        private System.Windows.Forms.TextBox yayini;
        private System.Windows.Forms.TextBox kitapCikisTarihi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dGVKitapListesi;
        private System.Windows.Forms.Button bntKitapSil;
        private System.Windows.Forms.Button btnKitapSec;
    }
}