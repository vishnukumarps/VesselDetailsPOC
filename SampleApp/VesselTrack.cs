using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp
{
    public class VesselTrack
    {
        public string POSITION { get; set; }
      
    }

    class POSITION
    {
        public string MMSI { get; set; }
        public string STATUS { get; set; }
        public string SPEED { get; set; }
        public string LON { get; set; }
        public string LAT { get; set; }
        public string COURCE { get; set; }
        public string HEADING { get; set; }

        public string SHIP_ID { get; set; }

        public DateTime TIMESTAMP { get; set; }

    }
}
