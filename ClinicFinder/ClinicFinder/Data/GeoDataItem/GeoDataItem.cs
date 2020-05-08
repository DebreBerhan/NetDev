using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicFinder.Data.GeoData
{
    public static class GeoDataItem
    {
         public static List<EtGeoData> Readfromfile()
        {
            List<EtGeoData> geoList = new List<EtGeoData>();

            var lines = System.IO.File.ReadAllLines("C:\\Projects\\ClinicFinder\\ClinicFinder\\Data\\GeoDataItem\\eth_healthfacility.csv");
            int i = 0;
            foreach (string item in lines)
            {
                if (i == 0)
                {
                    i++;

                }
                else
                {
                    EtGeoData HospitalLoc = new EtGeoData();
                    var values = item.Split(',');
                    HospitalLoc.HospitalName = Convert.ToString(values[3]);
                    //               HospitalLoc.HospitalType = Convert.ToString(values[4]);
                    HospitalLoc.latitude = Convert.ToDecimal(values[5]);
                    HospitalLoc.longitude = Convert.ToDecimal(values[6]);
                    geoList.Add(HospitalLoc);
                }
            }

            return geoList;
        }
    }
/*
    class HospitalLoc
    {
        public string Region;
        public string zone;
        public string Woreda;

        public string HospitalName;
        public string HospitalType;
        public decimal latitude;
        public decimal longitude;
        public int x1;
        public decimal N;
        public decimal E;
        public int Z;
        public static HospitalLoc FromCsv(string csvLine)
        {
            string[] values = csvLine.Split(',');
            HospitalLoc HospitalLoc = new HospitalLoc();
            HospitalLoc.Region = Convert.ToString(values[0]);
            HospitalLoc.zone = Convert.ToString(values[1]);
            HospitalLoc.Woreda = Convert.ToString(values[2]);
            HospitalLoc.HospitalName = Convert.ToString(values[3]);
            HospitalLoc.HospitalType = Convert.ToString(values[4]);
            HospitalLoc.latitude = Convert.ToDecimal(values[5]);
            HospitalLoc.longitude = Convert.ToDecimal(values[6]);
            HospitalLoc.x1 = Convert.ToInt32(values[7]);
            HospitalLoc.N = Convert.ToDecimal(values[8]);
            HospitalLoc.E = Convert.ToDecimal(values[9]);
            HospitalLoc.Z = Convert.ToInt32(values[9]);
            return HospitalLoc;
        }
    }
    */
}
