using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalniPotpis
{
    public class Serializer
    {
        public RSAParameters Deserialize<RSAParameters>(string input) where RSAParameters : class
        {
            System.Xml.Serialization.XmlSerializer ser = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));

            using (StringReader sr = new StringReader(input))
            {
                return (RSAParameters)ser.Deserialize(sr);
            }
        }
    }
}
