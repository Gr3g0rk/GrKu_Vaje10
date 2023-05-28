using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrkiDemo
{
    public partial class Form1 : Form
    {
        bool premakniLevo, premakniDesno, premakniGor, premakniDol;
        int hitrost = 5;


        public Form1()
        {
            InitializeComponent();
        }



        private void glavniTimerDogodek(object sender, EventArgs e)
        {
            if (premakniLevo == true && igralec.Left > 0)
            {
                igralec.Left -= hitrost; // igralca premaknemo za 12 pixlov v levo
            }

            if (premakniDesno == true && igralec.Right < this.Width)
            {
                igralec.Left += hitrost;
            }

            if (premakniGor == true && igralec.Top > 0)
            {
                igralec.Top -= hitrost;
            }

            if (premakniDol == true && igralec.Bottom < this.Height)
            {
                igralec.Top += hitrost;
            }



            foreach (Control x in Controls)
            {
                if (x is PictureBox && (string)x.Tag == "ovira")
                {
                    if (igralec.Bounds.IntersectsWith(x.Bounds))
                    {
                        x.BackColor= Color.Red;                      
                    }

                    else
                    {
                        x.BackColor = Color.Yellow;
                    }
                }
            }

        }


        /// <summary>
        /// Definiramo kaj se zgodi, ce pritiskamo tipke za premikanje
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pritisnjenGumb(object sender, KeyEventArgs e)
        {
            Console.WriteLine(e.KeyCode);

            if (e.KeyCode == Keys.Left)
            {
                premakniLevo = true;
            }

            if (e.KeyCode == Keys.Right)
            {
                premakniDesno = true;
            }

            if (e.KeyCode == Keys.Up)
            {
                premakniGor = true;
            }


            if (e.KeyCode == Keys.Down)
            {
                premakniDol = true;
            }
        }

        private void dvignjenGumb(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                premakniLevo = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                premakniDesno = false;
            }

            if (e.KeyCode == Keys.Up)
            {
                premakniGor = false;
            }


            if (e.KeyCode == Keys.Down)
            {
                premakniDol = false;
            }

        }
    }
}
