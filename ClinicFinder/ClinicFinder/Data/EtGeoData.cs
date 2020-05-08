using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicFinder.Data
{
    //clinical geo data in Ethiopia
    public class EtGeoData
    {
        public string  Region { get; set; }
        public string zone { get; set; }
        public string Woreda { get; set; }

        public string HospitalName { get; set; }
        public string HospitalType { get; set; }
        public decimal latitude { get; set; }
        public decimal longitude { get; set; }
        public int x1 { get; set; }
        public decimal  N { get; set; }
        public decimal E { get; set; }
        public int Z { get; set; }

    }
}
