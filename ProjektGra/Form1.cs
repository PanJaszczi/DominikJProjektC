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
        /*Zmienna slowo*/
        string slowo;
        /*Zmienna przechowująca liczbę pudeł*/
        int ile_pudel = 0;
        public Form1()
        {
            /*metoda losuj_slowo*/
            InitializeComponent();
            losuj_slowo();
        }

        /*Przycisk odsłoń literę*/
        private void button1_Click(object sender, EventArgs e)  
        {
            /*Instrukcja ile_pudel. Wykona się gdy liczba pudeł mniejsza niż 5*/
            if (ile_pudel < 5)
            {
                /*Zmienna litera przypisana do textboxa*/
                string litera = textBox1.Text;
                /*Zmienna logiczna typu bool. Fałsz przed sprawdzeniem*/
                bool czy_trafiony = false;
                /*Zmienna integer-przechowuje numer trafionej litery*/
                int gdzie_trafiony = 0;

                /*Pętla for wykonuje się 8 razy, bo pierwsza i ostatnia litera już jest wpisana*/
                for (int i = 1; i < 9; i++)
                {
                    /*Instrukcja warunkowa if-sprawdza czy podana litera jest taka sama jak litera ze zmiennej slowo*/
                    if (Convert.ToString(slowo[i]) == litera)
                    {
                        /*Jeśli podana litera znajduje się w słowie*/
                        czy_trafiony = true;
                        gdzie_trafiony = i;
                    }
                    /*Odczytanie jaka jest wartość zmiennej i wpisanie jej na odpowiednią etykietę*/
                    if (gdzie_trafiony == 1) { label2.Text = litera; }
                    if (gdzie_trafiony == 2) { label3.Text = litera; }
                    if (gdzie_trafiony == 3) { label4.Text = litera; }
                    if (gdzie_trafiony == 4) { label5.Text = litera; }
                    if (gdzie_trafiony == 5) { label6.Text = litera; }
                    if (gdzie_trafiony == 6) { label7.Text = litera; }
                    if (gdzie_trafiony == 7) { label8.Text = litera; }
                    if (gdzie_trafiony == 8) { label9.Text = litera; }
                }

                /*Sprawdzenie czy zmienna po przejśiu pętli nie zmieniła sowjej wartośći na prawda*/
                if (czy_trafiony == false)
                {
                    /*Jeżeli false liczba pudel zwiększa się*/
                    ile_pudel = ile_pudel + 1;
                    /*Po zwiększeniu pudeł wyświetla kolejno obrazki*/
                    if (ile_pudel == 1) { pictureBox1.Image = ProjektGra.Properties.Resources._2; }
                    if (ile_pudel == 2) { pictureBox1.Image = ProjektGra.Properties.Resources._3; }
                    if (ile_pudel == 3) { pictureBox1.Image = ProjektGra.Properties.Resources._4; }
                    if (ile_pudel == 4) { pictureBox1.Image = ProjektGra.Properties.Resources._5; }
                    if (ile_pudel == 5) { pictureBox1.Image = ProjektGra.Properties.Resources._6; }
                    if (ile_pudel == 6) { pictureBox1.Image = ProjektGra.Properties.Resources._7; }
                }
                wygrana();
            }
            /*Gdy warunek nie zostanie spełniony wyświetla obrazek przegrana*/
            else
            {
                pictureBox1.Image = ProjektGra.Properties.Resources.Lose;
            }
        }

        private void losuj_slowo()  /*Metoda losuj_slowo*/
        {   
            /*Tablica typu string przechowywuje słowa zagadki*/
            string[] slowa = {"absolutyzm", "agrobiznes", "akcesorium", "alergiczny", "arcybiskup", "astrofizyk", "bankietowy", "bankructwo", "bezchmurny", "biometryka", "biosynteza", "bohaterski", "bruzdowaty", "budowniczy", "bunkrowiec", "bursztynek", "butonierka", "cebulowaty", "ceglarstwo", "centralizm", "cholewkarz", "chuderlawy", "chwierutny", "ciemnorudy", "cmentarzyk", "czarowniej", "czempionat", "czerwoniak", "dawkomierz", "deputowany", "deskrypcja", "destrukcja", "detaliczny", "diabelstwo", "diagnostyk", "diamentowy", "dotkliwszy", "drutownica", "drylownica", "drzewostan", "dwusieczna", "dykcjonarz", "dysfunkcja", "dystrofizm", "dyszownica", "dywizjoner", "egzorcysta", "eksdywizja", "ekspozycja", "empirystka", "fechmistrz", "florecista", "fragmencik", "frontalizm", "furgonetka", "gabinetowy", "grabiestwo", "grudkowaty", "grzechotka", "guzdralski", "handlowiec", "hebrajczyk", "hipnotyzer", "hipokryzja", "humorzasty", "impotencja", "impulsator", "informatyk", "instrukcja", "jaskrowiec", "jazgotliwy", "jedwabisty", "kaletniczy", "katolicyzm", "kinetograf", "klasztorny", "konsumpcja", "korzenisty", "kuchmistrz", "kuglarstwo", "kuriozalny", "kwadrylion", "lekcjonarz", "liczykrupa", "lukrecjowy", "malborczyk", "malowniczy", "mankietowy", "markotniej", "masztowiec", "meblarstwo", "melodystka", "metaliczny", "miasteczko", "mieszkalny", "minuteczka", "mleczarski", "mocniejszy", "modlitewny", "mszycowate", "mrukliwszy", "murowaniec", "mydlarstwo", "najbielszy", "najbledszy", "najchudszy", "najgrubszy", "nieodparty", "nieurodzaj", "obskurniej", "obstrukcja", "obusieczny", "odczuwalny", "odwietrzny", "ogrzewnica", "opuchlizna", "pacierzowy", "paliczkowy", "pancerzowy", "parkingowy", "parszywiec", "pasibrzuch", "paskudztwo", "patrycjusz", "piekarstwo", "pietruszka", "piosenkarz ", "pistacjowy", "plastikowy", "podejrzany", "podgatunek", "podgrzybek", "pogardliwy", "pogranicze", "pokerzysta", "pomniejszy", "powietrzny", "powstaniec", "powszechny", "prawnuczek", "prosiaczek", "prostaczek", "przewodnik", "przyjaciel", "rachunkowy", "raptowniej", "rekwizycja", "relatywizm", "rotacyjnie", "rumiankowy", "sadowniczy", "samoczepny", "saneczkowy", "schludniej", "siarczkowy", "skrzeplina", "solidaryzm", "spadkowicz", "spedytorka", "spektralny", "sprzedajny", "stolniczka", "strachliwy", "strzelnica", "studenciak", "studzienka", "stypendium", "suchokwiat", "superlatyw", "supertajny", "szabrownik", "szacunkowy", "szlachetny", "sztabowiec", "szubrawiec", "tajemniczy", "topinambur", "towarzyski", "trawniczek", "tropikalny", "tulipanowy", "urokliwszy", "utrzymanek", "volkswagen", "wachmistrz", "wielkouchy", "wietrzysko", "windykator", "wizjonerka", "wolniejszy", "wulgarniej", "zaskroniec", "zielarstwo", "zyskowniej"};
            
            /*Zmienna ile_slow w typie Integer z nadaną wartośćią będącą liczbą elementów w tablicy slowa*/
            int ile_slow = slowa.Length;

            /*Generator losowania - Obiekt klasy Random*/
            Random gen = new Random();

            /*Metoda Next zwróci nam liczbę losową z podanego zakresu. Zapisana będzie w zmiennej typu int. */
            int indeks_slowa = gen.Next(0, ile_slow);

            /*Przypisane do zmiennej slowo wartość z tablicy slowa o wylosowanym indeksie.*/
            slowo = slowa[indeks_slowa];

            /*Wyświetlenie pierwszej i ostatniej litery wylosowanego słowa*/
            label1.Text = Convert.ToString(slowo[0]);
            label10.Text = Convert.ToString(slowo[9]);
        }

        /*Metoda wygrana-Jeśli wszystkie etykiety mają inny znak niż _ wyświetla obrazek wygrana*/
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

        /*Przycisk spróbuj ponownie*/
        private void button2_Click(object sender, EventArgs e)
        {
            /*wywołuje metodę losuj_slowo i zeruje grę*/
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
