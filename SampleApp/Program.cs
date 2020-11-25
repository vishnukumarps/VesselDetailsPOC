using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Xml;
using System.Xml.Linq;

namespace SampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpClient client = new HttpClient();

            HttpRequestMessage msg = new HttpRequestMessage(HttpMethod.Get,
                 "https://services.marinetraffic.com/api/exportvesseltrack/bad4c195e465b4c64a3db7287814e2bd513694c8/v:2/period:daily/days:3/mmsi:241486000");

            HttpResponseMessage resp = client.SendAsync(msg).Result;
            string val = resp.Content.ReadAsStringAsync().Result;

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(val);

            //var opResult = JsonConvert.DeserializeObject<POSITION>(val);

            string json = JsonConvert.SerializeXmlNode(doc);
             var   allData= JsonConvert.DeserializeObject<List<VesselTrack>>(json.ToString());





            Console.WriteLine("Hello World!");
        }
    }
}
