using Newtonsoft.Json;
using System;
using System.IO;
using System.Runtime.Serialization;
using System.Xml.Serialization;


namespace StandardXML
{
    class Program
    {
        static void Main(string[] args)
        {

            FileStream fs = new FileStream("d:\\pro2021\\liga.xml", FileMode.Create);
            XmlSerializer bf = new XmlSerializer(typeof(VsiSKupaj));
            VsiSKupaj v = new VsiSKupaj();
            bf.Serialize(fs, v);
            fs.Close();
            VsiSKupaj s = null;
            FileStream fs1 = new FileStream("d:\\pro2021\\liga.xml", FileMode.Open);
            XmlSerializer bf1 = new XmlSerializer(typeof(VsiSKupaj));
            try
            {
                s = (VsiSKupaj)bf1.Deserialize(fs1);
            }
            catch (SerializationException) { }
            finally { fs1.Close(); }
            foreach (Moštvo a in s.liga)
            {
                Console.WriteLine(a.Ime);
            }
            //VsiSKupaj v = new VsiSKupaj();
            //string json = JsonConvert.SerializeObject(v, Formatting.Indented);

            //FileStream fs = new FileStream("c:\\barbara\\liga.json", FileMode.Create);
            //StreamWriter s = new StreamWriter(fs);
            //s.Write(json);
            //s.Close();
            //VsiSKupaj v = JsonConvert.DeserializeObject<VsiSKupaj>(
            //    File.ReadAllText("c:\\barbara\\liga.json"));
            //foreach (Moštvo a in v.liga)
            //{
            //    Console.WriteLine(a.Ime);
            //}

            Console.ReadLine();
        }
    }
}
