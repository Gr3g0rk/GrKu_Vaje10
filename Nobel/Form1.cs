using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Threading.Tasks;

namespace Nobel
{
    public partial class Okno : Form
    {
        private const string location = @"Data Source=../../../nobelDB.db; Verison=3;";
        public Okno()
        {
            InitializeComponent();
        }

        private void OknoNalozi(object sender, EventArgs e)
        {
            SQLiteConnection povezava = new SQLiteConnection(location);
            povezava.Open();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT DISTINCT subject FROM nobel", povezava);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            podrocjeComboBox.DisplayMember = "subject";
            podrocjeComboBox.DataSource = dt;
            povezava.Close();
            
        }

        private async void Poisci(object sender, MouseEventArgs e)
        {
            string podrocje = podrocjeComboBox.Text.ToString();
            int leto;
            SQLiteConnection povezava = new SQLiteConnection(location);
            textBox.Clear();
            povezava.Open();
            string vnosLeto = letoTextBox.Text.Trim(' ');
            SQLiteCommand ukaz = new SQLiteCommand("SELECT * FROM nobel WHERE subject='" + podrocje + "'", povezava);
            if (int.TryParse(vnosLeto, out leto))
            {
                ukaz = new SQLiteCommand("SELECT * FROM nobel WHERE subject='" + podrocje + "' AND yr='" + leto + "'", povezava);
                await Task.Delay(5000);
            }
            else
            {
                letoTextBox.Text = "";
            }
            SQLiteDataReader rez = ukaz.ExecuteReader();
            while (rez.Read()) 
            {
                string vrstica = "";
                for (int i = 0; i < rez.VisibleFieldCount; i++)
                {
                    vrstica += rez[i].ToString() + " ";
                }
                textBox.Text += vrstica;
            }
            povezava.Close();

        }
    }
}
