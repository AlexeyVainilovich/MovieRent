using System.ComponentModel;
using System.Runtime.CompilerServices;
using MoviesRent;

namespace MovieRentWPF
{
    public class ApplicationViewModel : INotifyPropertyChanged
    {
        private MovieViewModel movieViewModel = new MovieViewModel(); 
        public MovieViewModel MovieView
        {
            get { return movieViewModel; }
            set { movieViewModel = value; }
        }








        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string prop)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
