using System.ComponentModel;
using System.Runtime.CompilerServices;
using MoviesRent;

namespace MovieRentWPF
{
    public class ApplicationViewModel : INotifyPropertyChanged
    {
        private Movie selectedMovie;
        private MovieCollection _Movies;
        public MovieCollection Movies
        {
            get { return _Movies; }
            set
            {
                _Movies = value;
                OnPropertyChanged("Movies");
            }
        }
        public void Add(Movie m)
        {
            Movies.Add(m);
        }
        private RelayCommand addCommand;
        public RelayCommand AddCommand
        {
            get
            {
                return addCommand ??
                  (addCommand = new RelayCommand(obj =>
                  {
                      Movie movie = new Movie();
                      movie.Name = "Fighting Club2";
                      Movies.Add(movie);
                      SelectedMovie = movie;
                  }));
            }
        }

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
            Movies = new MovieCollection() {
            new Movie { Name = "Filth", Age="18+", Date="2005", Genres="Action" }
            };
            Producer myProducer = new Producer { Name = "Eric" };
            ActorCollection myActor = new ActorCollection { new Actor { Name = "Alex"}, new Actor { Name = "Tom" }, new Actor { Name = "Bill" } };
            Movies.Add(new Movie { Name = "Fighting Club", Age = "18+", Date = "1999", Genres = "Action", Actors = myActor, Producer = myProducer });
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string prop)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
