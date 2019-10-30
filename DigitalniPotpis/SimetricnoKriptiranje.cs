using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DigitalniPotpis
{
    public class SimetricnoKriptiranje
    {
        public bool StvoriTajniKljuc()
        {
            bool greska = false;
            //string original = "Here is some data to encrypt!";
            using (Aes myAes = Aes.Create())
            {
                using (var fs = new FileStream("tajni_kljuc.txt", FileMode.Create, FileAccess.Write))
                {
                    fs.Write(myAes.Key, 0, myAes.Key.Length);
                }
                using (var fs = new FileStream("tajni_kljuc_vektor.txt", FileMode.Create, FileAccess.Write))
                {
                    fs.Write(myAes.IV, 0, myAes.IV.Length);
                }

                ////byte[]b= File.ReadAllBytes("tajni_kljuc.txt");

                //// Encrypt the string to an array of bytes.
                //byte[] encrypted = EncryptStringToBytes_Aes(original, myAes.Key, myAes.IV);

                //// Decrypt the bytes to a string.
                //string roundtrip = DecryptStringFromBytes_Aes(encrypted, myAes.Key, myAes.IV);

                ////Display the original data and the decrypted data.
                //Console.WriteLine("Original:   {0}", original);
                //Console.WriteLine("Round Trip: {0}", roundtrip);
            }
            return greska;
        }
        public string KriptirajTekst(string uneseniTekst)
        {
            //Dohvati tajni kljuc i njegov vektor
            byte[] tajniKljuc = File.ReadAllBytes("tajni_kljuc.txt");
            byte[] tajniKljucVektor = File.ReadAllBytes("tajni_kljuc_vektor.txt");
            // Encrypt the string to an array of bytes.

            if (string.IsNullOrEmpty(uneseniTekst) || uneseniTekst.Length <= 0)
                throw new ArgumentNullException("Unesite tekst.");
            if (tajniKljuc == null || tajniKljuc.Length <= 0)
                throw new ArgumentNullException("Tajni ključ nije generiran.");
            if (tajniKljucVektor == null || tajniKljucVektor.Length <= 0)
                throw new ArgumentNullException("Vektor tajnog ključa nije generiran.");
            byte[] kriptiraniTekst;

            // Create an Aes object
            // with the specified key and IV.
            using (Aes aes = Aes.Create())
            {
                aes.Key = tajniKljuc;
                aes.IV = tajniKljucVektor;

                // Create an encryptor to perform the stream transform.
                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                // Create the streams used for encryption.
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter sw = new StreamWriter(csEncrypt))
                        {
                            //Write all data to the stream.
                            sw.Write(uneseniTekst);
                        }
                        kriptiraniTekst = msEncrypt.ToArray();
                    }
                }
            }
            using (var fs = new FileStream("simetricno_kriptiranje.txt", FileMode.Create, FileAccess.Write))
            {
                fs.Write(kriptiraniTekst, 0, kriptiraniTekst.Length);
            }
            return File.ReadAllText("simetricno_kriptiranje.txt");
        }

        public string DekriptirajTekst()
        {
            byte[] tajniKljuc = File.ReadAllBytes("tajni_kljuc.txt");
            byte[] tajniKljucVektor = File.ReadAllBytes("tajni_kljuc_vektor.txt");
            byte[] kriptiraniTekst = File.ReadAllBytes("simetricno_kriptiranje.txt");

            // Check arguments.
            if (kriptiraniTekst == null || kriptiraniTekst.Length <= 0)
                throw new ArgumentNullException("Tekst za dekriptiranje nije unesen.");
            if (tajniKljuc == null || tajniKljuc.Length <= 0)
                throw new ArgumentNullException("Tajni kljuc nije generiran.");
            if (tajniKljucVektor == null || tajniKljucVektor.Length <= 0)
                throw new ArgumentNullException("Vektor tajnog kljuca nije generiran.");

            // Declare the string used to hold
            // the decrypted text.
            string pocetniTekst = null;

            // Create an Aes object
            // with the specified key and IV.
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = tajniKljuc;
                aesAlg.IV = tajniKljucVektor;

                // Create a decryptor to perform the stream transform.
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for decryption.
                using (MemoryStream msDecrypt = new MemoryStream(kriptiraniTekst))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {

                            // Read the decrypted bytes from the decrypting stream
                            // and place them in a string.
                            pocetniTekst = srDecrypt.ReadToEnd();
                        }
                    }
                }

            }

            return pocetniTekst;
        }

        public string DecryptStringFromBytes_Aes(byte[] cipherText, byte[] Key, byte[] IV)
        {
            // Check arguments.
            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException("cipherText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");

            // Declare the string used to hold
            // the decrypted text.
            string plaintext = null;

            // Create an Aes object
            // with the specified key and IV.
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                // Create a decryptor to perform the stream transform.
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for decryption.
                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {

                            // Read the decrypted bytes from the decrypting stream
                            // and place them in a string.
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }

            }
            return plaintext;
        }

    }
}
