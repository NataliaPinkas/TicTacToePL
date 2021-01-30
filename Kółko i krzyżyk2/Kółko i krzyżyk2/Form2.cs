using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kółko_i_krzyżyk2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Gracz1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // Warunek wpisania Nazw, aby przejśc dalej
        {
            if (g1.Text != "" && g2.Text != "")
            {
                Form1.Gracze(g1.Text, g2.Text);
                this.Close();
            }

            else
                MessageBox.Show("Wpisz nazwy graczy!", "Kółko i krzyżyk");
        }

        private void g2_KeyPress(object sender, KeyPressEventArgs e) //Pozwala wcisnąć Enter zamiast guzika
        {
            if (e.KeyChar.ToString() == "\r")
            button1.PerformClick();
        }

        private void Form2_Closing( object sender, System.ComponentModel.CancelEventArgs e)
        {
            Form stop = new Form1();
            stop.ShowDialog();
        }
    }
}
