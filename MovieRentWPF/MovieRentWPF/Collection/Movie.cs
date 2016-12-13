using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesRent
{
    public class Movie
    {
        private string movieName;
        public string MovieName
        {
            get
            {
                return movieName;
            }
            set
            {
                movieName = value;
            }
        }

        private string moviePoster;
        public string MoviePoster
        {
            get
            {
                return moviePoster;
            }
            set
            {
                moviePoster = value;
            }
        }

        private string movieGenres;
        public string MovieGenres
        {
            get
            {
                return movieGenres;
            }
            set
            {
                movieGenres = value;
            }
        }

        private string movieAge;
        public string MovieAge
        {
            get
            {
                return movieAge;
            }
            set
            {
                movieAge = value;
            }
        }

        private ActorCollection movieActors;
        public ActorCollection MovieActors
        {
            get
            {
                return movieActors;
            }
            set
            {
                movieActors = value;
            }
        }

        private Producer movieProducer;
        public Producer MovieProducer
        {
            get
            {
                return movieProducer;
            }
            set
            {
                movieProducer = value;
            }
        }

        private string movieDate;
        public string MovieDate
        {
            get
            {
                return movieDate;
            }
            set
            {
                movieDate = value;
            }
        }
        
        public Movie() { }
        public Movie(string name, string poster, string genres, string age, ActorCollection actors, Producer producer, string date)
        {
            movieName = name;
            moviePoster = poster;
            movieGenres = genres;
            movieAge = age;
            movieActors = actors;
            movieProducer = producer;
            movieDate = date;
        }

    }
}
