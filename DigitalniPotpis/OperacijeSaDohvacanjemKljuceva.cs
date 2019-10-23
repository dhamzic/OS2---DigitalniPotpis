using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DigitalniPotpis
{
    public class OperacijeSaDohvacanjemKljuceva
    {
        private System.Security.Cryptography.RSAParameters JavniKljuc { get; set; }
        private System.Security.Cryptography.RSAParameters PrivatniKljuc { get; set; }
        public string JavniKljucString { get; set; }
        public string PrivatniKljucString { get; set; }

        public OperacijeSaDohvacanjemKljuceva()
        {
            JavniKljucString = this.StvoriJavniKljuc();
            PrivatniKljucString = this.StvoriPrivatniKljuc();
        }


        #region StvaranjeJavnogKljuca
        public string StvoriJavniKljuc()
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(2048);
            JavniKljuc = rsa.ExportParameters(false);
            Serializer ser = new Serializer();
            RSAParameters xmlJavnogKljuca = ser.Deserialize<RSAParameters>(DohvatiStringKljuca(JavniKljuc));
            return xmlJavnogKljuca.Modulus;
        }
        #endregion
        #region StvaranjePrivatnogKljuca
        public string StvoriPrivatniKljuc()
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(2048);
            PrivatniKljuc = rsa.ExportParameters(true);
            Serializer ser = new Serializer();
            RSAParameters xmlPrivatnogKljuca = ser.Deserialize<RSAParameters>(DohvatiStringKljuca(PrivatniKljuc));
            return xmlPrivatnogKljuca.Modulus;
        }
        #endregion

        public string DohvatiStringKljuca(System.Security.Cryptography.RSAParameters kljuc)
        {
            string javniKljucString = "";
            var sw = new StringWriter();
            var xs = new XmlSerializer(typeof(System.Security.Cryptography.RSAParameters));
            xs.Serialize(sw, kljuc);
            javniKljucString = sw.ToString();
            return javniKljucString;
        }



    }
}
