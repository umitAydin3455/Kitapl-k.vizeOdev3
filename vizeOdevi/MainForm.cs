using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;


namespace vizeOdevi
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void bntClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKitaplik_Click(object sender, EventArgs e)
        {
            Kitaplik kitaplik = new Kitaplik();
            kitaplik.TopLevel = false;
            anaEkran.Controls.Add(kitaplik);
            kitaplik.BringToFront();
            kitaplik.Show();
        }
        private void btnUyeYonetimi_Click(object sender, EventArgs e)
        {
            UyeForm uyeForm = new UyeForm();
            uyeForm.TopLevel = false;
            anaEkran.Controls.Add(uyeForm);
            uyeForm.BringToFront();
            uyeForm.Show();
        }
        private void btnKitapYonetimi_Click(object sender, EventArgs e)
        {
            KitapForm kitapForm = new KitapForm();
            kitapForm.TopLevel = false;
            anaEkran.Controls.Add(kitapForm);
            kitapForm.BringToFront();
            kitapForm.Show();
        }
    }
}