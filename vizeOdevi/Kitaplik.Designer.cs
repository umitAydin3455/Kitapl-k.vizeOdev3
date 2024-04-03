namespace vizeOdevi
{
    partial class Kitaplik
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
            this.btnVeriGetir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DataGridViewRow = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewRow)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnVeriGetir);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1027, 63);
            this.panel1.TabIndex = 1;
            // 
            // btnVeriGetir
            // 
            this.btnVeriGetir.Location = new System.Drawing.Point(819, 28);
            this.btnVeriGetir.Name = "btnVeriGetir";
            this.btnVeriGetir.Size = new System.Drawing.Size(145, 23);
            this.btnVeriGetir.TabIndex = 1;
            this.btnVeriGetir.Text = "Veri Getir";
            this.btnVeriGetir.UseVisualStyleBackColor = true;
            this.btnVeriGetir.Click += new System.EventHandler(this.btnVeriGetir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "KİTAPLIK";
            // 
            // DataGridViewRow
            // 
            this.DataGridViewRow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DataGridViewRow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewRow.Location = new System.Drawing.Point(12, 69);
            this.DataGridViewRow.Name = "DataGridViewRow";
            this.DataGridViewRow.RowHeadersWidth = 51;
            this.DataGridViewRow.RowTemplate.Height = 24;
            this.DataGridViewRow.Size = new System.Drawing.Size(1003, 562);
            this.DataGridViewRow.TabIndex = 2;
            // 
            // Kitaplik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 643);
            this.ControlBox = false;
            this.Controls.Add(this.DataGridViewRow);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Kitaplik";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewRow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DataGridViewRow;
        private System.Windows.Forms.Button btnVeriGetir;
    }
}