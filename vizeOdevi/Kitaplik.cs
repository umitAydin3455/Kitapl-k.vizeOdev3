using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vizeOdevi
{
    public partial class Kitaplik : Form
    {
        public Kitaplik()
        {
            InitializeComponent();
        }

        private void btnVeriGetir_Click(object sender, EventArgs e)
        {
            // Kitap ve üye seçilip seçilmediğini kontrol et
            if (selectedBook != null && selectedMember != null)
            {
                // Seçilen kitap ve üyeyi birleştirerek BorrowedItem oluştur
                BorrowedItem borrowedItem = new BorrowedItem(selectedMember, selectedBook);

                // BorrowedItem'i DataGridView'e ekle
                dGVEmanet.DataSource = null;
                dGVEmanet.DataSource = new List<BorrowedItem> { borrowedItem };
            }
            else
            {
                MessageBox.Show("Lütfen bir kitap ve bir üye seçin.");
            }
        }
    }

}
