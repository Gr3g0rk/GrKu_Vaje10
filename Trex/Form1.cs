using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Letala
{
    public partial class Form1 : Form
    {
        // Predefinirana pot do datoteke z rezultati
        private string scoresFilePath = "scores.txt";

        bool skakanje = false;
        int hitrostskoka;
        int sila = 12;
        int sttock = 0;
        int hitrostOvir = 10;
        Random rand = new Random();
        bool konecIgre = false;
        int pozicija;

        List<Igralec> najboljsiRezultati;

        public Form1()
        {
            InitializeComponent();

            // Ustvari prazen seznam za najboljše rezultate
            najboljsiRezultati = new List<Igralec>();

            // Naloži najboljše rezultate iz datoteke
            LoadScores();

            // Izpiši najboljše rezultate
            UpdateBestScoresLabel();

            Reset();
        }

        private void casovnik_Tick(object sender, EventArgs e)
        {
            rex.Top += hitrostskoka;
            tocke.Text = sttock.ToString();

            if (skakanje == true && sila < 0)
            {
                skakanje = false;
            }
            if (skakanje == true)
            {
                hitrostskoka = -12;
                sila -= 1;
            }
            else
            {
                hitrostskoka = 12;
            }

            if (rex.Top > 275 && skakanje == false)
            {
                sila = 12;
                rex.Top = 276;
                hitrostskoka = 0;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "ovira")
                {
                    x.Left -= hitrostOvir;

                    if (x.Left < -100)
                    {
                        x.Left = this.ClientSize.Width + rand.Next(200, 500) + (x.Width * 15);
                        sttock++;
                    }

                    if (rex.Bounds.IntersectsWith(x.Bounds))
                    {
                        casovnik.Stop();
                        label1.Text += " Press R to restart the game!";
                        konecIgre = true;

                        // Preveri, ali je dosežen nov najboljši rezultat
                        if (sttock > GetLowestScore())
                        {
                            // Pridobi ime igralca
                            string ime = PromptForPlayerName();
                            if (!string.IsNullOrEmpty(ime))
                            {
                                // Dodaj nov najboljši rezultat v seznam
                                najboljsiRezultati.Add(new Igralec { Ime = ime, Tocke = sttock });

                                // Sortiraj seznam najboljših rezultatov
                                najboljsiRezultati.Sort();
                                najboljsiRezultati.Reverse();

                                // Omeji seznam na najboljših 10 rezultatov
                                if (najboljsiRezultati.Count > 10)
                                    najboljsiRezultati = najboljsiRezultati.Take(10).ToList();

                                // Posodobi datoteko z rezultati
                                SaveScores();

                                // Izpiši najboljše rezultate
                                UpdateBestScoresLabel();
                            }
                        }
                    }
                }
            }
            if (sttock > 5)
            {
                hitrostOvir = 15;
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && skakanje == false)
            {
                skakanje = true;
            }

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (skakanje == true)
            {
                skakanje = false;
            }

            if (e.KeyCode == Keys.R && konecIgre == true)
            {
                Reset();
            }
        }

        private void Reset()
        {
            label1.Text = string.Empty;
            sila = 12;
            hitrostskoka = 0;
            skakanje = false;
            sttock = 0;
            hitrostOvir = 10;
            tocke.Text = sttock.ToString();
            konecIgre = false;
            rex.Top = 276;

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "ovira")
                {
                    pozicija = this.ClientSize.Width + rand.Next(500, 800) + (x.Width * 10);
                    x.Left = pozicija;
                }
            }

            casovnik.Start();
        }

        private void UpdateBestScoresLabel()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Top 10 rezultatov:");
            int position = 1;
            foreach (Igralec igralec in najboljsiRezultati)
            {
                sb.AppendLine($"{position}. {igralec.Ime} - {igralec.Tocke}");
                position++;
            }
            najboljsiRezultatiLabel.Text = sb.ToString();
        }

        private int GetLowestScore()
        {
            if (najboljsiRezultati.Count > 0)
                return najboljsiRezultati.Min(igralec => igralec.Tocke);
            else
                return 0;
        }

        private string PromptForPlayerName()
        {
            using (var playerNameForm = new PlayerNameForm())
            {
                var result = playerNameForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    return playerNameForm.PlayerName;
                }
            }
            return string.Empty;
        }

        private void LoadScores()
        {
            if (File.Exists(scoresFilePath))
            {
                try
                {
                    // Preberemo vse vrstice iz datoteke
                    string[] lines = File.ReadAllLines(scoresFilePath);

                    // Iz vsake vrstice pridobimo ime in točke igralca ter jih dodamo v seznam
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 2)
                        {
                            string ime = parts[0].Trim();
                            int tocke;
                            if (int.TryParse(parts[1].Trim(), out tocke))
                            {
                                najboljsiRezultati.Add(new Igralec { Ime = ime, Tocke = tocke });
                            }
                        }
                    }

                    // Sortiramo seznam najboljših rezultatov
                    najboljsiRezultati.Sort();
                    najboljsiRezultati.Reverse();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Napaka pri branju datoteke rezultatov: {ex.Message}");
                }
            }
        }

        private void SaveScores()
        {
            try
            {
                // Pripravimo vrstice za shranjevanje
                List<string> lines = new List<string>();
                foreach (Igralec igralec in najboljsiRezultati)
                {
                    lines.Add($"{igralec.Ime},{igralec.Tocke}");
                }

                // Zapišemo vrstice v datoteko
                File.WriteAllLines(scoresFilePath, lines);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Napaka pri shranjevanju rezultatov: {ex.Message}");
            }
        }

        // Shranimo najboljše rezultate v datoteko, ko se aplikacija zapre
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);

            SaveScores();
        }
    }
}
class PlayerNameForm : Form
{
    private TextBox playerNameTextBox;
    private Button okButton;

    public PlayerNameForm()
    {
        InitializeComponents();
    }

    private void InitializeComponents()
    {
        playerNameTextBox = new TextBox();
        playerNameTextBox.Location = new Point(10, 10);
        playerNameTextBox.Size = new Size(200, 20);

        okButton = new Button();
        okButton.Text = "OK";
        okButton.Location = new Point(10, 40);
        okButton.Size = new Size(75, 23);
        okButton.DialogResult = DialogResult.OK;

        Controls.Add(playerNameTextBox);
        Controls.Add(okButton);

        AcceptButton = okButton;
        CancelButton = okButton;
    }

    public string PlayerName
    {
        get { return playerNameTextBox.Text; }
    }
}


