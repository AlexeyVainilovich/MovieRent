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
    class MovieViewModel : INotifyPropertyChanged
    {
        private Movie movie = new Movie();
        private string actors;
        private string producer;

        public MovieViewModel(){}

        public MovieViewModel(Movie m)
        {
            movie = m;
        }


        public Movie Return()
        {
            return movie;
        }

        public string Name
        {
            get { return movie.Name; }
            set
            {
                movie.Name = value;
                
            }
        }
        public string Porster
        {
            get { return movie.Poster; }
            set
            {
                movie.Poster = value;
               
            }
        }

        public string Genre
        {
            get { return movie.Genres; }
            set
            {
                movie.Genres = value;
                
            }
        }

        public string Age
        {
            get { return movie.Age; }
            set
            {
                movie.Age = value;
               
            }
        }

        public string Date
        {
            get { return movie.Date; }
            set
            {
                movie.Date = value;
                
            }
        }

        public string Actors
        {
            get
            {
                return actors;
            }
            set
            {
                actors = value;
            }
        }

        public string Producer
        {
            get {
                
                return producer;
            }
            set
            {
                producer = value;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string prop)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
