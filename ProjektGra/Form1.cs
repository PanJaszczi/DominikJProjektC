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
        public Form1()
        {
            InitializeComponent();
            losuj_slowo();
        }

        private void button1_Click(object sender, EventArgs e)
        {

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
    }
}
