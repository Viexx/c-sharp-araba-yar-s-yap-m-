using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace ArabaYarisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int kazanilanPuan = 0;
        int yolHizi = 15;
        int arabaHizi = 5; // bizim arabimizin hizi 

        bool solyon = false;
        bool sagyon = false;

        int digerArabahizi = 5; // diğer arabaların hızları


        Random rnd = new Random();


        public void oyunuBaslat()
        {
            btn_basla.Enabled = false;
            patlama.Visible = false;

            lbl_yuksekskor.Text = Settings1.Default.yuksekSkor.ToString();


            arabaHizi = 30;
            digerArabahizi = 30;
            kazanilanPuan = 0;

            // araba koordinatları -- bizim araba
            bizimaraba.Left = 160;
            bizimaraba.Top = 300;

            // diğer arabaların koordinatları (başlangıç)
            araba1.Left = 30;
            araba1.Top = 50;

            araba2.Left = 320;
            araba2.Top = 50;

            //araba3.Left = rnd.Next(25, 150);
            //araba3.Top = rnd.Next(35, 120);
            

            solyon = false;
            sagyon = false;

            patlama.Left = 165;
            patlama.Top = 294;

            timer1.Start();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            oyunuBaslat();
            sesAc();
        }


        private void sesAc()
        {
            SoundPlayer ses = new SoundPlayer();
            string sesyol = Application.StartupPath + "\\sarkı.wav";
            ses.SoundLocation = sesyol;
            ses.Play();

        }
        private void sesKapat()
        {
            SoundPlayer ses = new SoundPlayer();
            string sesyol = Application.StartupPath + "\\sarkı.wav";
            ses.SoundLocation = sesyol;
            ses.Stop();
            
        }




        private void timer1_Tick(object sender, EventArgs e)
        {
            kazanilanPuan++;
            lbl_skor.Text = kazanilanPuan.ToString();

            yol.Top += yolHizi;
            if (yol.Top > 100) { yol.Top = -100; }

            /* */
            if (Convert.ToInt32(lbl_skor.Text) > 200)
            {
                yolHizi = 30;
                arabaHizi = 50;
                digerArabahizi = 50;
                
            }

            if (Convert.ToInt32(lbl_skor.Text) > 400)
            {
                yolHizi = 60;
                arabaHizi = 80;
                digerArabahizi = 80;

            }

            if (Convert.ToInt32(lbl_skor.Text) > 800)
            {
                yolHizi = 80;
                arabaHizi = 100;
                digerArabahizi = 100;

            }

            if (solyon) { bizimaraba.Left -= arabaHizi; }
            if (sagyon) { bizimaraba.Left += arabaHizi; }

            if (bizimaraba.Left < 1) { solyon = false; }
            else if (bizimaraba.Left + bizimaraba.Width > 420) { sagyon = false; }


            araba1.Top += arabaHizi;
            araba2.Top += arabaHizi;

            if (araba1.Top > panel1.Height)
            {
                araba1degis();
                araba1.Left = rnd.Next(25, 100);
                araba1.Top = rnd.Next(50, 140) * -1;
            }
            if (araba2.Top > panel1.Height)
            {
                araba2degis();
                araba2.Left = rnd.Next(100, 350);
                araba2.Top = rnd.Next(40, 140) * -1;
            }
            if (bizimaraba.Bounds.IntersectsWith(araba1.Bounds) || bizimaraba.Bounds.IntersectsWith(araba2.Bounds))
            {
                oyunbitti();
            }

            /* yolu hızlandırma*/
            //if (Convert.ToInt32(lbl_skor) >= 800; )
            //{
            //    timer1.Interval = 80;
            //}
        }

        private void araba1degis()
        {
            int sira = rnd.Next(1, 7);

            switch (sira)
            {
                case 1:
                    araba1.Image = Properties.Resources.araba3;
                    break;
                case 2:
                    araba1.Image = Properties.Resources.araba5;
                    break;
                case 3:
                    araba1.Image = Properties.Resources.araba3;
                    break;
                case 4:
                    araba1.Image = Properties.Resources.araba4;
                    break;
                case 5:
                    araba1.Image = Properties.Resources.araba5;
                    break;
                case 6:
                    araba1.Image = Properties.Resources.araba6;
                    break;
                case 7:
                    araba1.Image = Properties.Resources.araba7;
                    break;

            }
        }
        private void araba2degis()
        {
            int sira = rnd.Next(1, 7);

            switch (sira)
            {
                case 1:
                    araba2.Image = Properties.Resources.araba3;
                    break;
                case 2:
                    araba2.Image = Properties.Resources.araba5;
                    break;
                case 3:
                    araba2.Image = Properties.Resources.araba3;
                    break;
                case 4:
                    araba2.Image = Properties.Resources.araba4;
                    break;
                case 5:
                    araba2.Image = Properties.Resources.araba5;
                    break;
                case 6:
                    araba2.Image = Properties.Resources.araba6;
                    break;
                case 7:
                    araba2.Image = Properties.Resources.araba7;
                    break;

            }
        }

        private void oyunbitti()
        {
            timer1.Stop();
            if (Convert.ToInt32(lbl_skor.Text) > Convert.ToInt32(Settings1.Default.yuksekSkor.ToString()))
            {
                Settings1.Default.yuksekSkor = lbl_skor.Text;
            }

            sesKapat();
            
            btn_basla.Enabled = true;
            patlama.Visible = true;
            bizimaraba.Controls.Add(patlama);
            patlama.Location = new Point(7, -5);
            patlama.BringToFront();
            patlama.BackColor = Color.Transparent;
            MessageBox.Show("Tebrikler Skorunuz : " + lbl_skor.Text, "Oyun Bitti", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && bizimaraba.Left > 0) { solyon = true; }
            if (e.KeyCode == Keys.Right && bizimaraba.Left + bizimaraba.Width < panel1.Width) { sagyon = true; }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) { solyon = false; }
            if (e.KeyCode == Keys.Right) { sagyon = false; }
        }

        private void btn_basla_Click(object sender, EventArgs e)
        {
            oyunuBaslat();
            sesAc();
        }
    }
}
