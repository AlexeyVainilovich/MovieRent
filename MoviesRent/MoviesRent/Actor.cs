using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MoviesRent
{
    public class Actor : INotifyPropertyChanged
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

        private string photo;
        public string Photo
        {
            get
            {
                return photo;
            }
            set
            {
                photo = value;
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

        private string biography;
        public string Biography
        {
            get
            {
                return biography;
            }
            set
            {
                biography = value;
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

        public Actor() { }
        public Actor(string _name,string _date, string _biography, MovieCollection _movies)
        {
            name = _name;
            date = _date;
            biography = _biography;
            movies = _movies;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

    }
}
