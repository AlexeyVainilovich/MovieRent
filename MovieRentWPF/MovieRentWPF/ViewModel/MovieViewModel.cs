using MoviesRent;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentWPF
{
    public class MovieViewModel : INotifyPropertyChanged
    {
        private Movie selectedMovie;
        private string listOfActors;
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
        public string ListOfActors
        {
            get { return listOfActors; }
            set { listOfActors = value; }
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
                      Producer producer = new Producer() {Name = "Producer" };
                      movie.Name = "Name";
                      movie.Age = "Age";
                      movie.Date = "Date";
                      movie.Poster = "/Images/westworld.jpg";
                      movie.Genres = "Genres";
                      movie.Producer = producer;
                      Movies.Add(movie);
                      SelectedMovie = movie;
                  }));
            }
        }

        private RelayCommand saveCommand;
        public RelayCommand SaveCommand
        {
            get
            {
                return saveCommand ??
                  (saveCommand = new RelayCommand(obj =>
                  {

                      ActorCollection actorCollection = new ActorCollection() {new  Actor() { Name = listOfActors } };
                      SelectedMovie.Actors = actorCollection;
                      OnPropertyChanged("SelectedMovie");
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

        public MovieViewModel()
        {
            Movies = new MovieCollection() {
            new Movie { Name = "Filth", Age="18+", Date="2005", Genres="Action" }
            };
            Producer myProducer = new Producer { Name = "Eric" };
            ActorCollection myActor = new ActorCollection { new Actor { Name = "Alex" }, new Actor { Name = "Tom" }, new Actor { Name = "Bill" } };
            Movies.Add(new Movie { Name = "Fighting Club", Age = "18+", Date = "1999", Genres = "Action", Actors = myActor, Producer = myProducer });
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string prop)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
