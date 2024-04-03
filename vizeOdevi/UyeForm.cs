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
using vizeOdevi;

namespace vizeOdevi
{
    public partial class UyeForm : Form
    {
        private List<Member> members = new List<Member>();
        private string jsonFilePath = Path.Combine(Application.StartupPath, "members.json");

        public UyeForm()
        {
            InitializeComponent();
            LoadMembersFromJson();
        }

        private void LoadMembersFromJson()
        {
            if (File.Exists(jsonFilePath))
            {
                string json = File.ReadAllText(jsonFilePath);
                members = JsonConvert.DeserializeObject<List<Member>>(json);
                RefreshDataGridView();
            }
        }

        private void SaveMembersToJson()
        {
            string json = JsonConvert.SerializeObject(members);
            File.WriteAllText(jsonFilePath, json);
        }

        private void ekle_Click(object sender, EventArgs e)
        {
            string ad = adTextBox.Text;
            string soyad = soyadTextBox.Text;
            string telno = telnoTextBox.Text;
            string email = emailTextBox.Text;

            Member newMember = new Member(ad, soyad, telno, email);
            members.Add(newMember);
            SaveMembersToJson();
            RefreshDataGridView();
            MessageBox.Show("Üye başarıyla kaydedildi.");
        }

        private void RefreshDataGridView()
        {
            dGVÜyeListesi.DataSource = null;
            dGVÜyeListesi.DataSource = members;
        }

        private void sil_Click(object sender, EventArgs e)
        {
            if (dGVÜyeListesi.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dGVÜyeListesi.SelectedRows[0];
                Member selectedMember = (Member)selectedRow.DataBoundItem;
                members.Remove(selectedMember);
                SaveMembersToJson();
                RefreshDataGridView();
                MessageBox.Show("Seçilen üye başarıyla silindi.");
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz üyeyi seçin.");
            }
        }
        private Member selectedMember;
        //-----------------------------
        private void btnUyeSec_Click(object sender, EventArgs e)
        {
            // Üye formunu aç ve seçimi bekle
            UyeForm uyeForm = new UyeForm();
            if (uyeForm.ShowDialog() == DialogResult.OK)
            {
                selectedMember = uyeForm.SelectedMember;
            }
        }
        //-----------------------------
    }

    public class Member
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Telno { get; set; }
        public string Email { get; set; }

        public Member(string ad, string soyad, string telno, string email)
        {
            Ad = ad;
            Soyad = soyad;
            Telno = telno;
            Email = email;
        }
    }
}
