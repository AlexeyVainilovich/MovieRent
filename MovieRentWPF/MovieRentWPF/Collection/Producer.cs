using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesRent
{
    public class Producer
    {
        private string producerName;
        public string ProducerName
        {
            get
            {
                return producerName;
            }
            set
            {
                producerName = value;
            }
        }

        private MovieCollection producerMovies;
        public MovieCollection ProducerMovies
        {
            get
            {
                return producerMovies;
            }
            set
            {
                producerMovies = value;
            }
        }

        public Producer() { }
        public Producer(string name, MovieCollection movies)
        {
            producerName = name;
            producerMovies = movies;
        }

    }
}
