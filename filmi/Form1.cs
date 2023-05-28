using System;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data;

namespace filmi
{
    public partial class Okno : Form
    {
        private const string povNiz = @"Data Source=filmi.sqlite; Version=3;";
        private DataSet dataSet;

        public Okno()
        {
            InitializeComponent();
        }

        private void OknoNalozi(object sender, EventArgs e)
        {
            using (SQLiteConnection povezava = new SQLiteConnection(povNiz))
            {
                SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT id, naslov, leto, reziser FROM filmi", povezava);
                dataSet = new DataSet();
                adapter.Fill(dataSet, "Filmi");

                DataTable filmiTable = dataSet.Tables["Filmi"];
                foreach (DataRow row in filmiTable.Rows)
                {
                    DataGridViewRow vrstica = new DataGridViewRow();
                    vrstica.CreateCells(dataGridView);
                    vrstica.Cells[0].Value = row["id"].ToString();
                    vrstica.Cells[1].Value = row["naslov"].ToString();
                    vrstica.Cells[2].Value = row["leto"].ToString();
                    vrstica.Cells[3].Value = row["reziser"].ToString();
                    dataGridView.Rows.Add(vrstica);
                }
            }
        }

        private void Poisci(object sender, MouseEventArgs e)
        {
            string vnosLeto = letoTextBox.Text;
            int leto;
            using (SQLiteConnection povezava = new SQLiteConnection(povNiz))
            {
                povezava.Open();
                SQLiteCommand ukaz;
                if (int.TryParse(vnosLeto, out leto))
                {
                    dataGridView.Rows.Clear();
                    ukaz = new SQLiteCommand("SELECT id, naslov, leto, reziser FROM filmi WHERE leto = '" + leto + "'", povezava);
                }
                else
                {
                    ukaz = new SQLiteCommand("SELECT id, naslov, leto, reziser FROM filmi", povezava);
                    letoTextBox.Text = "";
                }

                SQLiteDataAdapter adapter = new SQLiteDataAdapter(ukaz);
                dataSet = new DataSet();
                adapter.Fill(dataSet, "SearchResults");

                DataTable searchResultsTable = dataSet.Tables["SearchResults"];
                foreach (DataRow row in searchResultsTable.Rows)
                {
                    DataGridViewRow vrstica = new DataGridViewRow();
                    vrstica.CreateCells(dataGridView);
                    vrstica.Cells[0].Value = row["id"].ToString();
                    vrstica.Cells[1].Value = row["naslov"].ToString();
                    vrstica.Cells[2].Value = row["leto"].ToString();
                    vrstica.Cells[3].Value = row["reziser"].ToString();
                    dataGridView.Rows.Add(vrstica);
                }
            }
        }
    }
}
