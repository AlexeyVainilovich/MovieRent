using System;
using MoviesRent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace MovieRentWPF.ViewModel
{
    class ActorViewModel : INotifyPropertyChanged
    {
        private Actor selectedActor;
        private string listOfMovies;
        private ActorCollection _Actors;

        public ActorCollection Actors
        {
            get { return _Actors; }
            set
            {
                _Actors = value;
                OnPropertyChanged("Actors");
            }
        }

        public string ListOfActors
        {
            get { return listOfMovies; }
            set { listOfMovies = value; }
        }

        private RelayCommand addCommand;
        public RelayCommand AddCommand
        {
            get
            {
                return addCommand ??
                  (addCommand = new RelayCommand(obj =>
                  {
                      Actor actor = new Actor();
                      actor.Name = "Name";
                      actor.Biography = "Biography";
                      actor.Date = "Date";
                      Actors.Add(actor);
                      SelectedActor = actor;
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

                      MovieCollection movieCollection = new MovieCollection() { new Movie() { Name = listOfMovies } };
                      SelectedActor.Movies= movieCollection;
                      OnPropertyChanged("SelectedActor");
                  }));
            }
        }

        public Actor SelectedActor
        {
            get { return selectedActor; }
            set
            {
                selectedActor = value;
                OnPropertyChanged("SelectedMovie");
            }
        }

        public ActorViewModel() {}

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string prop)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
