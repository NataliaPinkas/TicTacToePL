using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Kółko_i_krzyżyk2
{
    public partial class Form1 : Form
    {
        bool tura = true; //dla rundy gracza X bool=!true, dla O bool = true
        int turaNr = 0;
        static String gracz1, gracz2;

        public Form1()
        {
            InitializeComponent();
        }

        public static void Gracze(string g1, string g2) //Przypisanie nazw graczy z poprzedniego formularza //OPISANAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
        {
            gracz1 = g1;
            gracz2 = g2;
        } 

        private void Wyjscie_Click(object sender, EventArgs e) //OPISANAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
        {
            Application.Exit();
        }

        private void klik(object sender, EventArgs e) // Wpisanie znaku w pole po kliknięciu i przejście do następnej rundy // OPISANAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
        {
            Button p = (Button)sender;

            if (tura)
            {
                p.Text = "O";

            }
            else
                p.Text = "X";

            tura = !tura;
            p.Enabled = false;
           turaNr++;
           CzyWygrana();
        }
        private void CzyWygrana()
        {
            bool wygrana = false;

            if ((TL.Text == TM.Text) && (TM.Text == TR.Text) && (!TL.Enabled)) //TopLeft, TopMid, TopRight - W POZIOMIE
                wygrana = true;
            if ((ML.Text == MM.Text) && (MM.Text == MR.Text) && (!ML.Enabled)) //MidLeft, MidMid, MidRight
                wygrana = true;
            if ((BL.Text == BM.Text) && (BM.Text == BR.Text) && (!BL.Enabled)) //BottomLeft, BottomMid, BottomRight
                wygrana = true;
            if ((TL.Text == ML.Text) && (ML.Text == BL.Text) && (!TL.Enabled)) // - W PIONIE
                wygrana = true;
            if ((TM.Text == MM.Text) && (MM.Text == BM.Text) && (!TM.Enabled))
                wygrana = true;
            if ((TR.Text == MR.Text) && (MR.Text == BR.Text) && (!TR.Enabled))
                wygrana = true;
            if ((TL.Text == MM.Text) && (MM.Text == BR.Text) && (!TL.Enabled)) // - NA UKOS
                wygrana = true;
            if ((TR.Text == MM.Text) && (MM.Text == BL.Text) && (!TR.Enabled))
                wygrana = true;

            if (wygrana) // Wypisanie w formularzu kto wygrał, jeśli jest zwycięzca
            {
               Wylacz();
                String zwyciezca = "";
                if (tura)
                {
                    zwyciezca = gracz2;
                    XWygrane.Text = (Int32.Parse(XWygrane.Text) + 1).ToString();
                }
                else
                {
                    zwyciezca = gracz1;
                    OWygrane.Text = (Int32.Parse(OWygrane.Text) + 1).ToString();
                }

                MessageBox.Show("Zwycięża " + zwyciezca + "!", "Kółko i krzyżyk");
            }
            else
            {
                if (turaNr == 9)
                {
                    MessageBox.Show("Remis!", "Kółko i krzyżyk");
                }
            }
        }

        private void Wylacz() // Odznaczenie pól po skończonej rundzie
        {
            TR.Enabled = false;
            TM.Enabled = false;
            TL.Enabled = false;
            MR.Enabled = false;
            MM.Enabled = false;
            ML.Enabled = false;
            BR.Enabled = false;
            BM.Enabled = false;
            BL.Enabled = false;
        }

        private void NGra_Click(object sender, EventArgs e) //Przycisk nowej gry - reset rundy, wywołanie metody resetującej pola
        {         
            Nowa();
        } //OPISANAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA

        private void Nowa() // Metoda czyszcząca zawartość pól, umożliwiająca zaznaczenie pól //OPISANAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
        {
            tura = true;
            turaNr = 0;

            TR.Enabled = true;
            TM.Enabled = true;
            TL.Enabled = true;
            MR.Enabled = true;
            MM.Enabled = true;
            ML.Enabled = true;
            BR.Enabled = true;
            BM.Enabled = true;
            BL.Enabled = true;

            TR.Text = "";
            TM.Text = "";
            TL.Text = "";
            MR.Text = "";
            MM.Text = "";
            ML.Text = "";
            BR.Text = "";
            BM.Text = "";
            BL.Text = "";
        }

        private void Enter(object sender, EventArgs e) // Najechanie na pole myszką umożliwia zorientowanie się czyja jest tura // OPISANAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
        {
            Button p = (Button)sender;
            if (p.Enabled)
            {
                if (tura)
                    p.Text = "O";
                else
                    p.Text = "X";
            }
        }

        private void Leave(object sender, EventArgs e) // Przesunięcie myszki z danego pola (bez klikania), sprawia że jest ono znów puste (odwrotność metody wyżej) // OPISANAAAAAAAAAAAAAAAAAAAAAA
        {
            Button p = (Button)sender;
            if (p.Enabled)
            {
                p.Text = "";
            }
        }

        private void Reset_Click(object sender, EventArgs e) // Przycisk reset - wyzerowanie licznika punktów i pól //OPISANAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
        {
            XWygrane.Text = "0";
            OWygrane.Text = "0";

            Nowa();
        }

        private void Form1_Load(object sender, EventArgs e) // Załadowanie formularza gry po uzupełnieniu pierwszego formularza //OPISANAAAAAAAAAAAAAAAAAAAAAAAAA
        {
            if (gracz1 != "" && gracz2 != "")

            {
                Form start = new Form2();
                start.ShowDialog();
                Gracz1.Text = gracz1;
                label1.Text = gracz2;
            }

            else
                this.Close();
        }
    }
}
