using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
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
        }

        private void UiJavniKljucButton_Click(object sender, EventArgs e)
        {
            AsimetricnoKriptiranje ak = new AsimetricnoKriptiranje();

            if (ak.StvoriKljuceve() == false)
            {
                MessageBox.Show("Javni i privatni ključ uspješno stvoreni!", "Asimetrično");
            }
            else
            {
                MessageBox.Show("Javni i privatni ključ nisu stvoreni.", "Greška");
            }

        }

        private void UiAsimetricnoKriptiranjeButton_Click(object sender, EventArgs e)
        {
            AsimetricnoKriptiranje ak = new AsimetricnoKriptiranje();
            UiTekstZaKriptiranjeTxt.Text = ak.KriptirajTekst(UiTekstZaKriptiranjeTxt.Text);
        }

        private void UiAsimetricnoDekriptiranjeButton_Click(object sender, EventArgs e)
        {
            AsimetricnoKriptiranje ak = new AsimetricnoKriptiranje();
            UiTekstZaKriptiranjeTxt.Text = ak.DekriptirajTekst();
        }

        private void UiSimetricnoKriptiranjeButton_Click(object sender, EventArgs e)
        {
            SimetricnoKriptiranje sk = new SimetricnoKriptiranje();
            UiTekstZaKriptiranjeTxt.Text = sk.KriptirajTekst(UiTekstZaKriptiranjeTxt.Text);
        }

        private void UiTajniKljucButton_Click(object sender, EventArgs e)
        {
            SimetricnoKriptiranje sk = new SimetricnoKriptiranje();

            if (sk.StvoriTajniKljuc() == false)
            {
                MessageBox.Show("Tajni ključ uspješno stvoren!", "Simetrično");
            }
            else
            {
                MessageBox.Show("Tajni ključ neuspješno stvoren!", "Greška");
            }
        }

        private void UiSimetricnoDekriptiranjeButton_Click(object sender, EventArgs e)
        {
            SimetricnoKriptiranje sk = new SimetricnoKriptiranje();
            UiTekstZaKriptiranjeTxt.Text = sk.DekriptirajTekst();
        }

        private void UiKreirajSazetakButton_Click(object sender, EventArgs e)
        {
            AsimetricnoKriptiranje ak = new AsimetricnoKriptiranje();
            MessageBox.Show("Sažetak uspješno izračunat:\n+" + ak.KreirajSazetakKriptiranePoruke(), "Sažetak poruke");
        }

        private void UiDigitalanPotpisButton_Click(object sender, EventArgs e)
        {
            AsimetricnoKriptiranje ak = new AsimetricnoKriptiranje();
            if (ak.DigitalnoPotpisiPoruku() == true)
            {
                MessageBox.Show("Poruka uspješno potpisana!", "Digitalni potpis");
            }
            else
            {
                MessageBox.Show("Poruka nije potpisana.", "Digitalni potpis");
            }

        }

        private void UiProvjeriPotpisButton_Click(object sender, EventArgs e)
        {
            AsimetricnoKriptiranje ak = new AsimetricnoKriptiranje();
            if (ak.ProvjeriPotpisPoruke() == true)
            {
                MessageBox.Show("Tekst je validan i originalan.", "Digitalni potpis");
            }
            else
            {
                MessageBox.Show("Tekst nije validan.", "Digitalni potpis");
            }
        }
    }
}
