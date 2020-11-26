using System;
using System.Net.Http;
using System.Xml;

namespace Wheather
{
    class Program
    {
        static void Main(string[] args)
        {
            var  lat = "9.9312";
            var lng = "76.2673";
            var @params = "waveHeight,airTemperature,windSpeed,waterTemperature,cloudCover,airTemperature80m";
            //var source = "meto,dwd,icon,meteo,fmi,yr,smhi,sg";
            var sourcemphr";


            HttpClient client = new HttpClient();

            HttpRequestMessage msg = new HttpRequestMessage(HttpMethod.Get,
                 "https://api.stormglass.io/v2/weather/point?lat="+lat+"&lng="+lng+"&params="+@params+"&source="+source+"");

            msg.Headers.Add("Authorization", "63091298-2f09-11eb-ad61-0242ac130002-63091338-2f09-11eb-ad61-0242ac130002");
            HttpResponseMessage resp = client.SendAsync(msg).Result;
            string val = resp.Content.ReadAsStringAsync().Result;

           

          
            Console.WriteLine("Hello World!");
        }
    }
}
