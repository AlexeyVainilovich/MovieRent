using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MoviesRent
{
    public class Movie
    {
        public string name;
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

        private string poster;
        public string Poster
        {
            get
            {
                return poster;
            }
            set
            {
                poster = value;
           
            }
        }

        private string genres;
        public string Genres
        {
            get
            {
                return genres;
            }
            set
            {
               genres = value;
               
            }
        }

        private string age;
        public string Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            
            }
        }
        
        private ActorCollection actors;
        public ActorCollection Actors
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

        private Producer producer;
        public Producer Producer
        {
            get
            {
                return producer;
            }
            set
            {
                producer = value;
            }
        }
        private string date;
        public string Date
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
              
            }
        }
        
        public Movie() { }
        public Movie(string _name, string _poster, string _genres, string _age, ActorCollection _actors, Producer _producer, string _date)
        {
            name = _name;
            poster = _poster;
            genres = _genres;
            age = _age;
            actors = _actors;
            producer = _producer;
            date = _date;
        }
        
        
    }
}
