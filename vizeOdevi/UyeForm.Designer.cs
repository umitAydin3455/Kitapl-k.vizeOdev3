namespace vizeOdevi
{
    partial class UyeForm
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
            this.dGVÜyeListesi = new System.Windows.Forms.DataGridView();
            this.ekle = new System.Windows.Forms.Button();
            this.adTextBox = new System.Windows.Forms.TextBox();
            this.soyadTextBox = new System.Windows.Forms.TextBox();
            this.ad = new System.Windows.Forms.Label();
            this.soyad = new System.Windows.Forms.Label();
            this.sil = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.telefon = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.telnoTextBox = new System.Windows.Forms.TextBox();
            this.btnUyeSec = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVÜyeListesi)).BeginInit();
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
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "ÜYE YÖNETİMİ";
            // 
            // dGVÜyeListesi
            // 
            this.dGVÜyeListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVÜyeListesi.Location = new System.Drawing.Point(276, 68);
            this.dGVÜyeListesi.Name = "dGVÜyeListesi";
            this.dGVÜyeListesi.RowHeadersWidth = 51;
            this.dGVÜyeListesi.RowTemplate.Height = 24;
            this.dGVÜyeListesi.Size = new System.Drawing.Size(739, 563);
            this.dGVÜyeListesi.TabIndex = 1;
            // 
            // ekle
            // 
            this.ekle.Location = new System.Drawing.Point(12, 424);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(169, 59);
            this.ekle.TabIndex = 2;
            this.ekle.Text = "EKLE";
            this.ekle.UseVisualStyleBackColor = true;
            this.ekle.Click += new System.EventHandler(this.ekle_Click);
            // 
            // adTextBox
            // 
            this.adTextBox.Location = new System.Drawing.Point(15, 193);
            this.adTextBox.Name = "adTextBox";
            this.adTextBox.Size = new System.Drawing.Size(242, 22);
            this.adTextBox.TabIndex = 3;
            // 
            // soyadTextBox
            // 
            this.soyadTextBox.Location = new System.Drawing.Point(15, 255);
            this.soyadTextBox.Name = "soyadTextBox";
            this.soyadTextBox.Size = new System.Drawing.Size(242, 22);
            this.soyadTextBox.TabIndex = 4;
            // 
            // ad
            // 
            this.ad.AutoSize = true;
            this.ad.Location = new System.Drawing.Point(15, 171);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(30, 16);
            this.ad.TabIndex = 5;
            this.ad.Text = "Ad :";
            // 
            // soyad
            // 
            this.soyad.AutoSize = true;
            this.soyad.Location = new System.Drawing.Point(12, 236);
            this.soyad.Name = "soyad";
            this.soyad.Size = new System.Drawing.Size(53, 16);
            this.soyad.TabIndex = 6;
            this.soyad.Text = "Soyad :";
            // 
            // sil
            // 
            this.sil.Location = new System.Drawing.Point(187, 424);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(67, 59);
            this.sil.TabIndex = 7;
            this.sil.Text = "SİL";
            this.sil.UseVisualStyleBackColor = true;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Email :";
            // 
            // telefon
            // 
            this.telefon.AutoSize = true;
            this.telefon.Location = new System.Drawing.Point(9, 298);
            this.telefon.Name = "telefon";
            this.telefon.Size = new System.Drawing.Size(80, 16);
            this.telefon.TabIndex = 10;
            this.telefon.Text = "Telefon No :";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(12, 380);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(242, 22);
            this.emailTextBox.TabIndex = 9;
            // 
            // telnoTextBox
            // 
            this.telnoTextBox.Location = new System.Drawing.Point(15, 317);
            this.telnoTextBox.Name = "telnoTextBox";
            this.telnoTextBox.Size = new System.Drawing.Size(242, 22);
            this.telnoTextBox.TabIndex = 8;
            // 
            // btnUyeSec
            // 
            this.btnUyeSec.Location = new System.Drawing.Point(121, 549);
            this.btnUyeSec.Name = "btnUyeSec";
            this.btnUyeSec.Size = new System.Drawing.Size(136, 23);
            this.btnUyeSec.TabIndex = 0;
            this.btnUyeSec.Text = "Üye Seç";
            this.btnUyeSec.Click += new System.EventHandler(this.btnUyeSec_Click);
            // 
            // UyeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1027, 643);
            this.ControlBox = false;
            this.Controls.Add(this.btnUyeSec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.telefon);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.telnoTextBox);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.soyad);
            this.Controls.Add(this.ad);
            this.Controls.Add(this.soyadTextBox);
            this.Controls.Add(this.adTextBox);
            this.Controls.Add(this.ekle);
            this.Controls.Add(this.dGVÜyeListesi);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UyeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVÜyeListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dGVÜyeListesi;
        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.TextBox adTextBox;
        private System.Windows.Forms.TextBox soyadTextBox;
        private System.Windows.Forms.Label ad;
        private System.Windows.Forms.Label soyad;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label telefon;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox telnoTextBox;
        private System.Windows.Forms.Button btnUyeSec;
    }
}