using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesRent
{
    public class Actor
    {
        private string actorName;
        public string ActorName
        {
            get
            {
                return actorName;
            }
            set
            {
                actorName = value;
            }
        }

        private string actorPhoto;
        public string ActorPhoto
        {
            get
            {
                return actorPhoto;
            }
            set
            {
                actorPhoto = value;
            }
        }

        private string actorDate;
        public string ActorDate
        {
            get
            {
                return actorDate;
            }
            set
            {
                actorDate = value;
            }
        }

        private string actorBiography;
        public string ActorBiography
        {
            get
            {
                return actorBiography;
            }
            set
            {
                actorBiography = value;
            }
        }

        private MovieCollection actorMovies;
        public MovieCollection ActorMovies
        {
            get
            {
                return actorMovies;
            }
            set
            {
                actorMovies = value;
            }
        }

        public Actor() { }
        public Actor(string name,string date, string biography, MovieCollection movies)
        {
            actorName = name;
            actorDate = date;
            actorBiography = biography;
            actorMovies = movies;
        }


    }
}
