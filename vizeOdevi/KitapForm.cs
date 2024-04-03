using Newtonsoft.Json;
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
using System.Xml.XPath;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace vizeOdevi
{
    public partial class KitapForm : Form
    {
        private List<Book> books = new List<Book>();
        private string jsonFilePath = Path.Combine(Application.StartupPath, "books.json");
        private DateTime kitapCikisTarih;

        public KitapForm()
        {
            InitializeComponent();
            LoadBooksFromJson();
        }
        private void LoadBooksFromJson()
        {
            if (File.Exists(jsonFilePath))
            {
                string json = File.ReadAllText(jsonFilePath);
                books = JsonConvert.DeserializeObject<List<Book>>(json);
                RefreshDataGridView();
            }
        }
        private void SaveBooksToJson()
        {
            string json = JsonConvert.SerializeObject(books);
            File.WriteAllText(jsonFilePath, json);
        }
        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            string kitapAd = kitapAdi.Text;
            string kitapYazar = kitapYazari.Text;
            string yayin = yayini.Text;
            string KitapCikisTarih = kitapCikisTarihi.Text;


            Book newBook = new Book(kitapAd, kitapYazar, yayin, kitapCikisTarih);
            books.Add(newBook);
            SaveBooksToJson();
            RefreshDataGridView();
            kitapAdi.Text = "";
            kitapYazari.Text = "";
            yayini.Text = "";
            kitapCikisTarihi.Text = "";

            MessageBox.Show("Kitap başarıyla kaydedildi.");
        }
        private void RefreshDataGridView()
        {
            dGVKitapListesi.DataSource = null;
            dGVKitapListesi.DataSource = books;
        }

        private void bntKitapSil_Click(object sender, EventArgs e)
        {
            if (dGVKitapListesi.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dGVKitapListesi.SelectedRows[0];
                Book selectedBook = (Book)selectedRow.DataBoundItem;
                books.Remove(selectedBook);
                SaveBooksToJson();
                RefreshDataGridView();
                MessageBox.Show("Seçilen kitap başarıyla silindi.");
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz kitabı seçin.");
            }
        }
        //-----------------------------
        private Book selectedBook;
        private void btnKitapSec_Click(object sender, DataGridViewCellEventArgs e)
        {
            // Kitap formunu aç ve seçimi bekle
            KitapForm kitapForm = new KitapForm();
            if (kitapForm.ShowDialog() == DialogResult.OK)
            {
                selectedBook = kitapForm.SelectedBook;
            }
        }
        //-----------------------------
    }
    public class Book
    {
        public string KitapAd { get; set; }
        public string KitapYazar { get; set; }
        public string yayin { get; set; }
        public DateTime KitapCikisTarih { get; set; }

        public Book(string kitapAdi, string kitapYazari, string yayini, DateTime kitapCikisTarihi)
        {
            KitapAd = kitapAdi;
            KitapYazar = kitapYazari;
            yayin = yayini;
            KitapCikisTarih = kitapCikisTarihi;
        }
    }
}
