using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;

namespace MovieRentWPF
{
    public class ApplicationViewModel1 : INotifyPropertyChanged
    {
        private Phone selectedPhone;

        public ObservableCollection<Phone> Phones { get; set; }
        public Phone SelectedPhone
        {
            get { return selectedPhone; }
            set
            {
                selectedPhone = value;
                OnPropertyChanged("SelectedPhone");
            }
        }

        public ApplicationViewModel1()
        {
            Phones = new ObservableCollection<Phone>
            {
                new Phone {MovieName="iPhone 7", Company="Apple", Price=56000 },
                new Phone {MovieName="Galaxy S7 Edge", Company="Samsung", Price =60000 },
                new Phone {MovieName="Elite x3", Company="HP", Price=56000 },
                new Phone {MovieName="Mi5S", Company="Xiaomi", Price=35000 }
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }

}
