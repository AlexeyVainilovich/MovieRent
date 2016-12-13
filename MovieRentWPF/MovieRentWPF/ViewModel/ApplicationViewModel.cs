using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;
using MoviesRent;

namespace MovieRentWPF
{
    public class ApplicationViewModel : INotifyPropertyChanged
    {
        private Movie selectedMovie;

        public MovieCollection Movies;

        public Movie SelectedMovie
        {
            get { return selectedMovie; }
            set
            {
                selectedMovie = value;
                OnPropertyChanged("SelectedMovie");
            }
        }

        public ApplicationViewModel()
        {
            Movies = new MovieCollection();
            
            Movies.Add(new Movie { MovieName = "Filth1" });
            Movies.Add(new Movie { MovieName = "Filth2" });
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
