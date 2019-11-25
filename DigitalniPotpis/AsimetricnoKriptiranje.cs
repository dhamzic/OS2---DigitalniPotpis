using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DigitalniPotpis
{
    public class AsimetricnoKriptiranje
    {
        //RSA BIBLIOTEKA

        public bool StvoriKljuceve()
        {
            bool pogreska = false;

            try
            {
                var rsa = new RSACryptoServiceProvider(2048);

                var privatniKljuc = rsa.ExportParameters(true);
                var javniKljuc = rsa.ExportParameters(false);

                var sw = new System.IO.StringWriter();
                var xs = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));

                xs.Serialize(sw, javniKljuc);
                string javniKljucString = sw.ToString();

                sw = new System.IO.StringWriter();
                xs = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));

                xs.Serialize(sw, privatniKljuc);
                string privatniKljucString = sw.ToString();

                //Zapisivanje u datoteku
                System.IO.File.WriteAllText(@"javni_kljuc.txt", javniKljucString);
                System.IO.File.WriteAllText(@"privatni_kljuc.txt", privatniKljucString);
            }
            catch (Exception)
            {
                pogreska = true;
            }
            return pogreska;
        }
        public string KriptirajTekst(string uneseniTekst)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();

            var javniKljuc = rsa.ExportParameters(false);
            var privatniKljuc = rsa.ExportParameters(true);

            //Dohvati javni kljuc iz datoteke
            var sr = new System.IO.StringReader(System.IO.File.ReadAllText(@"javni_kljuc.txt"));
            var xs = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));

            javniKljuc = (RSAParameters)xs.Deserialize(sr);

            rsa = new RSACryptoServiceProvider();
            rsa.ImportParameters(javniKljuc);

            var tekstZaKriptiranje = uneseniTekst;

            var tekstBajtniOblik = System.Text.Encoding.Unicode.GetBytes(tekstZaKriptiranje);
            var kriptiraniTekstBajtniOblik = rsa.Encrypt(tekstBajtniOblik, false);

            var kriptiraniTekst = Convert.ToBase64String(kriptiraniTekstBajtniOblik);

            //Zapisivanje u datoteku
            System.IO.File.WriteAllText(@"asimetricno_kriptiranje.txt", kriptiraniTekst);
            return kriptiraniTekst;
        }
        public string DekriptirajTekst()
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();

            var privatniKljuc = rsa.ExportParameters(true);

            string kriptiraniTekst = System.IO.File.ReadAllText(@"asimetricno_kriptiranje.txt");
            var kriptiraniTekstBajtniOblik = Convert.FromBase64String(kriptiraniTekst.ToString());

            var sr = new System.IO.StringReader(System.IO.File.ReadAllText(@"privatni_kljuc.txt"));
            var xs = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));

            privatniKljuc = (RSAParameters)xs.Deserialize(sr);
            rsa.ImportParameters(privatniKljuc);

            var tekstBajtniOblik = rsa.Decrypt(kriptiraniTekstBajtniOblik, false);

            return System.Text.Encoding.Unicode.GetString(tekstBajtniOblik);
        }

        public string KreirajSazetakKriptiranePoruke()
        {
            SHA512 hashFunkcija = SHA512.Create();
            byte[] sazetakKriptiranePoruke;

            //Dohvacanje asimetricnog kriptiranja teksta i izračunavanje sažetka kriptiranog teksta
            var kriptiraniTekst = Convert.FromBase64String(System.IO.File.ReadAllText(@"asimetricno_kriptiranje.txt"));
            sazetakKriptiranePoruke = hashFunkcija.ComputeHash(kriptiraniTekst);

            //Zapisivanje sažetka u .txt
            System.IO.File.WriteAllBytes(@"sazetak.txt", sazetakKriptiranePoruke);

            return Convert.ToBase64String(sazetakKriptiranePoruke);


        }
    }
}
