using System;
using MoviesRent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentWPF.ViewModel
{
    class ProducerViewModel : INotifyPropertyChanged
    {
        private Producer selectedProducer;
        private string listOfMovies;
        private ProducerCollection _Producers;

        public ProducerCollection Producers
        {
            get { return _Producers; }
            set
            {
                _Producers = value;
                OnPropertyChanged("Producers");
            }
        }
        public string ListOfMovies
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
                      Producer producer = new Producer();
                      producer.Name = "Name";
                      Producers.Add(producer);
                      SelectedProducer = producer;
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
                      SelectedProducer.Movies = movieCollection;
                      OnPropertyChanged("SelectedProducer");
                  }));
            }
        }

        public Producer SelectedProducer
        {
            get { return selectedProducer; }
            set
            {
                selectedProducer = value;
                OnPropertyChanged("SelectedProducer");
            }
        }

        public ProducerViewModel() { }
        

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string prop)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
