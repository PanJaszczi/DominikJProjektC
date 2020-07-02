using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektGra
{
    public partial class Form1 : Form
    {
        string slowo;
        int ile_pudel = 0;
        public Form1()
        {
            InitializeComponent();
            losuj_slowo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ile_pudel < 5)
            {
                string litera = textBox1.Text;
                bool czy_trafiony = false;
                int gdzie_trafiony = 0;

                for (int i = 1; i < 9; i++)
                {
                    if (Convert.ToString(slowo[i]) == litera)
                    {
                        czy_trafiony = true;
                        gdzie_trafiony = i;
                    }
                    if (gdzie_trafiony == 1) { label2.Text = litera; }
                    if (gdzie_trafiony == 2) { label3.Text = litera; }
                    if (gdzie_trafiony == 3) { label4.Text = litera; }
                    if (gdzie_trafiony == 4) { label5.Text = litera; }
                    if (gdzie_trafiony == 5) { label6.Text = litera; }
                    if (gdzie_trafiony == 6) { label7.Text = litera; }
                    if (gdzie_trafiony == 7) { label8.Text = litera; }
                    if (gdzie_trafiony == 8) { label9.Text = litera; }
                }

                if (czy_trafiony == false)
                {
                    ile_pudel = ile_pudel + 1;
                    if (ile_pudel == 1) { pictureBox1.Image = ProjektGra.Properties.Resources._2; }
                    if (ile_pudel == 2) { pictureBox1.Image = ProjektGra.Properties.Resources._3; }
                    if (ile_pudel == 3) { pictureBox1.Image = ProjektGra.Properties.Resources._4; }
                    if (ile_pudel == 4) { pictureBox1.Image = ProjektGra.Properties.Resources._5; }
                    if (ile_pudel == 5) { pictureBox1.Image = ProjektGra.Properties.Resources._6; }
                    if (ile_pudel == 6) { pictureBox1.Image = ProjektGra.Properties.Resources._7; }
                }
                wygrana();
            }
            else
            {
                pictureBox1.Image = ProjektGra.Properties.Resources.Lose;
            }
        }

        private void losuj_slowo()
        {   
            string[] slowa = {"absolutyzm", "agrobiznes", "akcesorium", "alergiczny", "arcybiskup", "astrofizyk", "bankietowy", "bankructwo", "bezchmurny", "biometryka", "biosynteza", "bohaterski", "bruzdowaty", "budowniczy", "bunkrowiec", "bursztynek", "butonierka", "cebulowaty", "ceglarstwo", "centralizm", "cholewkarz", "chuderlawy", "chwierutny", "ciemnorudy", "cmentarzyk", "czarowniej", "czempionat", "czerwoniak", "dawkomierz", "deputowany", "deskrypcja", "destrukcja", "detaliczny", "diabelstwo", "diagnostyk", "diamentowy", "dotkliwszy", "drutownica", "drylownica", "drzewostan", "dwusieczna", "dykcjonarz", "dysfunkcja", "dystrofizm", "dyszownica", "dywizjoner", "egzorcysta", "eksdywizja", "ekspozycja", "empirystka", "fechmistrz", "florecista", "fragmencik", "frontalizm", "furgonetka", "gabinetowy", "grabiestwo", "grudkowaty", "grzechotka", "guzdralski", "handlowiec", "hebrajczyk", "hipnotyzer", "hipokryzja", "humorzasty", "impotencja", "impulsator", "informatyk", "instrukcja", "jaskrowiec", "jazgotliwy", "jedwabisty", "kaletniczy", "katolicyzm", "kinetograf", "klasztorny", "konsumpcja", "korzenisty", "kuchmistrz", "kuglarstwo", "kuriozalny", "kwadrylion", "lekcjonarz", "liczykrupa", "lukrecjowy", "malborczyk", "malowniczy", "mankietowy", "markotniej", "masztowiec", "meblarstwo", "melodystka", "metaliczny", "miasteczko", "mieszkalny", "minuteczka", "mleczarski", "mocniejszy", "modlitewny", "mszycowate", "mrukliwszy", "murowaniec", "mydlarstwo", "najbielszy", "najbledszy", "najchudszy", "najgrubszy", "nieodparty", "nieurodzaj", "obskurniej", "obstrukcja", "obusieczny", "odczuwalny", "odwietrzny", "ogrzewnica", "opuchlizna", "pacierzowy", "paliczkowy", "pancerzowy", "parkingowy", "parszywiec", "pasibrzuch", "paskudztwo", "patrycjusz", "piekarstwo", "pietruszka", "piosenkarz ", "pistacjowy", "plastikowy", "podejrzany", "podgatunek", "podgrzybek", "pogardliwy", "pogranicze", "pokerzysta", "pomniejszy", "powietrzny", "powstaniec", "powszechny", "prawnuczek", "prosiaczek", "prostaczek", "przewodnik", "przyjaciel", "rachunkowy", "raptowniej", "rekwizycja", "relatywizm", "rotacyjnie", "rumiankowy", "sadowniczy", "samoczepny", "saneczkowy", "schludniej", "siarczkowy", "skrzeplina", "solidaryzm", "spadkowicz", "spedytorka", "spektralny", "sprzedajny", "stolniczka", "strachliwy", "strzelnica", "studenciak", "studzienka", "stypendium", "suchokwiat", "superlatyw", "supertajny", "szabrownik", "szacunkowy", "szlachetny", "sztabowiec", "szubrawiec", "tajemniczy", "topinambur", "towarzyski", "trawniczek", "tropikalny", "tulipanowy", "urokliwszy", "utrzymanek", "volkswagen", "wachmistrz", "wielkouchy", "wietrzysko", "windykator", "wizjonerka", "wolniejszy", "wulgarniej", "zaskroniec", "zielarstwo", "zyskowniej"};
            int ile_slow = slowa.Length;

            Random gen = new Random();
            int indeks_slowa = gen.Next(0, ile_slow);
            slowo = slowa[indeks_slowa];

            label1.Text = Convert.ToString(slowo[0]);
            label10.Text = Convert.ToString(slowo[9]);
        }

        private void wygrana()
        {
            if (label2.Text != "_")
            {
                if (label3.Text != "_")
                {
                    if (label4.Text != "_")
                    {
                        if (label5.Text != "_")
                        {
                            if (label6.Text != "_")
                            {
                                if (label7.Text != "_")
                                {
                                    if (label8.Text != "_")
                                    {
                                        if (label9.Text != "_")
                                        {
                                            pictureBox1.Image = ProjektGra.Properties.Resources.Win;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            losuj_slowo();
            label2.Text = "_";
            label3.Text = "_";
            label4.Text = "_";
            label5.Text = "_";
            label6.Text = "_";
            label7.Text = "_";
            label8.Text = "_";
            label9.Text = "_";
            ile_pudel = 0;
        }
    }
}
