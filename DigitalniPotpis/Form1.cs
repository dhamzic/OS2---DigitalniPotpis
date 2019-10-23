using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DigitalniPotpis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            OperacijeSaDohvacanjemKljuceva pokreniOperacijeZaDohvacanjeKljuceva = new OperacijeSaDohvacanjemKljuceva();
            MessageBox.Show("Javni kljuc:\n\n"+pokreniOperacijeZaDohvacanjeKljuceva.JavniKljucString+ "\n\n\nPrivatni kljuc:\n\n"+pokreniOperacijeZaDohvacanjeKljuceva.PrivatniKljucString);
        }


    }
}
