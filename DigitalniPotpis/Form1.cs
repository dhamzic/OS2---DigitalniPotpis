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

        //private void UiPrivatniKljucButton_Click(object sender, EventArgs e)
        //{
        //    OperacijeSaDohvacanjemKljuceva pokreniOperacijeZaDohvacanjeKljuceva = new OperacijeSaDohvacanjemKljuceva();
        //    MessageBox.Show(pokreniOperacijeZaDohvacanjeKljuceva.StvoriPrivatniKljuc(), "Privatni ključ");
        //}

        //private void UiTajniKljucButton_Click(object sender, EventArgs e)
        //{
        //    OperacijeSaDohvacanjemKljuceva pokreniOperacijeZaDohvacanjeKljuceva = new OperacijeSaDohvacanjemKljuceva();
        //    MessageBox.Show(pokreniOperacijeZaDohvacanjeKljuceva.StvoriTajniKljuc(), "Privatni ključ");
        //}

        //private void UiKriptirajButton_Click(object sender, EventArgs e)
        //{


        //    //javni kljuc je za kriptiranje


        //    var csp = new RSACryptoServiceProvider(2048);

        //    //how to get the private key
        //    var privKey = csp.ExportParameters(true);

        //    //and the public key ...
        //    var pubKey = csp.ExportParameters(false);

        //    //converting the public key into a string representation

        //        //we need some buffer
        //        var sw = new System.IO.StringWriter();
        //        //we need a serializer
        //        var xs = new System.Xml.Serialization.XmlSerializer(typeof(System.Security.Cryptography.RSAParameters));
        //        //serialize the key into the stream
        //        xs.Serialize(sw, pubKey);
        //        //get the string from the stream
        //        string pubKeyString = sw.ToString();


        //    csp = new RSACryptoServiceProvider();
        //    csp.ImportParameters(pubKey);

        //    //we need some data to encrypt
        //    var plainTextData = textBox1.Text;

        //    //for encryption, always handle bytes...
        //    var bytesPlainTextData = System.Text.Encoding.Unicode.GetBytes(plainTextData);

        //    //apply pkcs#1.5 padding and encrypt our data 
        //    var bytesCypherText = csp.Encrypt(bytesPlainTextData, false);

        //    //we might want a string representation of our cypher text... base64 will do
        //    var cypherText = Convert.ToBase64String(bytesCypherText);




        //    bytesCypherText = Convert.FromBase64String(cypherText);

        //    //we want to decrypt, therefore we need a csp and load our private key
        //    csp = new RSACryptoServiceProvider();
        //    csp.ImportParameters(privKey);

        //    //decrypt and strip pkcs#1.5 padding
        //    bytesPlainTextData = csp.Decrypt(bytesCypherText, false);

        //    //get our original plainText back...
        //    plainTextData = System.Text.Encoding.Unicode.GetString(bytesPlainTextData);
        //}
    }
}
