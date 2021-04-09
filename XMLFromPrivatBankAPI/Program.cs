using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Text;
using System.Collections.Generic;

namespace XMLFromPrivatBankAPI
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string str = await GetData();
            XmlSerializer serializer = new XmlSerializer(typeof(DataOffice));
            DataOffice office = null;
            using (MemoryStream ms = new MemoryStream(Encoding.Default.GetBytes(str)))
            {
               office =  serializer.Deserialize(ms) as DataOffice;
            }
            foreach(var pb in office.Offices)
            {
                Console.WriteLine($"{pb.City} {pb.Name}");
            }
        }

        static async Task<string> GetData()
        {
            Console.WriteLine("Hello World!");
            string str = "";
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage resp = await client.GetAsync("https://api.privatbank.ua/p24api/pboffice?city=Кривой Рог");
                str = await resp.Content.ReadAsStringAsync();
                //Console.WriteLine(str);
            }
            return str;
        }
    }
}
