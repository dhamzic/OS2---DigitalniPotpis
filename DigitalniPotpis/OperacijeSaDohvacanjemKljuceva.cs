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
        }


        //#region Asimetricni kljucevi
        //#region StvaranjeJavnogKljuca
        //public string StvoriJavniKljuc()
        //{
        //    RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(2048);
        //    JavniKljuc = rsa.ExportParameters(false);
        //    Serializer ser = new Serializer();
        //    string stringJavnogKljuca = DohvatiStringKljuca(JavniKljuc);
        //    RSAParameters xmlJavnogKljuca = ser.Deserialize<RSAParameters>(stringJavnogKljuca);
        //    System.IO.File.WriteAllText(@"javni_kljuc.txt", stringJavnogKljuca);
        //    return stringJavnogKljuca;
        //}
        //#endregion
        //#region StvaranjePrivatnogKljuca
        //public string StvoriPrivatniKljuc()
        //{
        //    RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(2048);
        //    PrivatniKljuc = rsa.ExportParameters(true);
        //    Serializer ser = new Serializer();
        //    string stringPrivatnogKljuca = DohvatiStringKljuca(PrivatniKljuc);
        //    RSAParameters xmlPrivatnogKljuca = ser.Deserialize<RSAParameters>(stringPrivatnogKljuca);
        //    System.IO.File.WriteAllText(@"privatni_kljuc.txt", stringPrivatnogKljuca);
        //    return stringPrivatnogKljuca;
        //}
        //#endregion 
        //#endregion

        //public string StvoriTajniKljuc()
        //{
        //    Aes aes = Aes.Create();
        //    FileStream fs = new FileStream("tajni_kljuc.txt", FileMode.Create);
        //    fs.Write(aes.Key, 0, aes.Key.Length);
        //    fs.Close();
        //    return "";
        //}


        //public string DohvatiStringKljuca(System.Security.Cryptography.RSAParameters kljuc)
        //{
        //    string javniKljucString = "";
        //    var sw = new StringWriter();
        //    var xs = new XmlSerializer(typeof(System.Security.Cryptography.RSAParameters));
        //    xs.Serialize(sw, kljuc);
        //    javniKljucString = sw.ToString();
        //    return javniKljucString;
        //}



    }
}
