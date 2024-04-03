namespace vizeOdevi
{
    partial class MainForm
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
            this.anaEkran = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bntClose = new System.Windows.Forms.Button();
            this.btnKitaplik = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnKitapYonetimi = new System.Windows.Forms.Button();
            this.btnUyeYonetimi = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // anaEkran
            // 
            this.anaEkran.BackColor = System.Drawing.Color.White;
            this.anaEkran.Location = new System.Drawing.Point(187, 23);
            this.anaEkran.Name = "anaEkran";
            this.anaEkran.Size = new System.Drawing.Size(1029, 645);
            this.anaEkran.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.bntClose);
            this.panel3.Location = new System.Drawing.Point(187, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1029, 24);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "KÜTÜPHANE";
            // 
            // bntClose
            // 
            this.bntClose.BackgroundImage = global::vizeOdevi.Properties.Resources.Ekran_görüntüsü_2024_03_24_040223;
            this.bntClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bntClose.Location = new System.Drawing.Point(999, 0);
            this.bntClose.Name = "bntClose";
            this.bntClose.Size = new System.Drawing.Size(28, 23);
            this.bntClose.TabIndex = 0;
            this.bntClose.UseVisualStyleBackColor = true;
            this.bntClose.Click += new System.EventHandler(this.bntClose_Click);
            // 
            // btnKitaplik
            // 
            this.btnKitaplik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKitaplik.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnKitaplik.Location = new System.Drawing.Point(12, 234);
            this.btnKitaplik.Name = "btnKitaplik";
            this.btnKitaplik.Size = new System.Drawing.Size(156, 35);
            this.btnKitaplik.TabIndex = 1;
            this.btnKitaplik.Text = "KİTAPLIK";
            this.btnKitaplik.UseVisualStyleBackColor = true;
            this.btnKitaplik.Click += new System.EventHandler(this.btnKitaplik_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.anaEkran);
            this.panel1.Controls.Add(this.btnKitapYonetimi);
            this.panel1.Controls.Add(this.btnUyeYonetimi);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnKitaplik);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1217, 668);
            this.panel1.TabIndex = 0;
            // 
            // btnKitapYonetimi
            // 
            this.btnKitapYonetimi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKitapYonetimi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnKitapYonetimi.Location = new System.Drawing.Point(12, 364);
            this.btnKitapYonetimi.Name = "btnKitapYonetimi";
            this.btnKitapYonetimi.Size = new System.Drawing.Size(156, 35);
            this.btnKitapYonetimi.TabIndex = 8;
            this.btnKitapYonetimi.Text = "Kitap Yönetimi";
            this.btnKitapYonetimi.UseVisualStyleBackColor = true;
            this.btnKitapYonetimi.Click += new System.EventHandler(this.btnKitapYonetimi_Click);
            // 
            // btnUyeYonetimi
            // 
            this.btnUyeYonetimi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUyeYonetimi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUyeYonetimi.Location = new System.Drawing.Point(12, 298);
            this.btnUyeYonetimi.Name = "btnUyeYonetimi";
            this.btnUyeYonetimi.Size = new System.Drawing.Size(156, 35);
            this.btnUyeYonetimi.TabIndex = 7;
            this.btnUyeYonetimi.Text = "Üye Yönetimi";
            this.btnUyeYonetimi.UseVisualStyleBackColor = true;
            this.btnUyeYonetimi.Click += new System.EventHandler(this.btnUyeYonetimi_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::vizeOdevi.Properties.Resources.Ekran_görüntüsü_2024_03_29_101018;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 668);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel anaEkran;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnKitaplik;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnKitapYonetimi;
        private System.Windows.Forms.Button btnUyeYonetimi;
        private System.Windows.Forms.Button bntClose;
        private System.Windows.Forms.Label label1;
    }
}

