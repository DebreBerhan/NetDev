using ClinicFinder.Data;
using ClinicFinder.Data.GeoData;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicFinder.ViewModel
{
    class ClinicalLocationModel : INotifyPropertyChanged
    {
        private ObservableCollection<EtGeoData> _items { get; set; }
        public ObservableCollection<EtGeoData> Items
        {
            get { return _items; }
            set
            {
                _items = value;
                OnPropertyRaised("Item");
            }
        }

      
        List<EtGeoData> data2 = GeoDataItem.Readfromfile();
         
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyRaised(string propertyname)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }
        }

    }
}
