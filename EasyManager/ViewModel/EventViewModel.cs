using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.Devices.AllJoyn;
using Windows.UI.Xaml;
using EasyManager.Model;
using EasyManager.Common;

namespace EasyManager.ViewModel
{
    public class EventViewModel:NotifyPropertyChanged
    {
        // -------------------Fields-------------------------

        private EventCatalogSingleton _eventCatalogSingleton = EventCatalogSingleton.Instance;
        private Event _selectedEvent;
        private ObservableCollection<Event> _eventsCollection;


        // ------------------Properties--------------------
      

        public EventCatalogSingleton EventCatalogSingleton {
            get
            {
                return _eventCatalogSingleton;
            }
            set
            {
                _eventCatalogSingleton = value;
                OnPropertyChanged(nameof(_eventCatalogSingleton));
            }
        }

        public ObservableCollection<Event> EventsCollection {
            get
            {
                return _eventsCollection; 
                
            }
            set
            {
                _eventsCollection = value;
                OnPropertyChanged(nameof(EventsCollection));
            }
        }

        public EventHandlerClass eventHandler { get; set; }
        
        public RelayCommand CreateEventCommand { get; set; }

        public RelayCommand DeleteEventCommand { get; set; }
        
        public Event SelectedEvent {
            get
            {
                return _selectedEvent;
            }
            set
            {
                _selectedEvent = value;
                OnPropertyChanged(nameof(SelectedEvent));
                
            } 
        }


        // ---------Properties for Event---------------------
        
        public string Name { get; set;}
        public string Place { get; set;}
        public string Description { get; set;}
        public DateTimeOffset Date { get; set;}
        public DateTimeOffset Time { get; set;}


        // ------------------Constructor---------------------

        public EventViewModel()
        {
            EventsCollection = _eventCatalogSingleton.GetEventCatalogSingleton();
            SelectedEvent = new Event();
            eventHandler = new EventHandlerClass(this);
            CreateEventCommand = new RelayCommand(eventHandler.CreateEvent);
            DeleteEventCommand = new RelayCommand(eventHandler.DeleteEvent);
        }   

    }
}
