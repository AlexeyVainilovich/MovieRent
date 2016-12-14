using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesRent
{
    public class Producer
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        private MovieCollection movies;
        public MovieCollection Movies
        {
            get
            {
                return movies;
            }
            set
            {
                movies = value;
            }
        }

        public Producer() { }
        public Producer(string _name, MovieCollection _movies)
        {
            name = _name;
            movies = _movies;
        }

    }
}
