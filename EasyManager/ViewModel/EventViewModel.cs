using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using System.Windows.Input;
using EasyManager.Model;
using EasyManager.Common;

namespace EasyManager.ViewModel
{
    class EventViewModel
    {
        // -------------------Fields------------------- ---

        private EventCatalogSingleton _eventCatalogSingleton;
        private Event e;
        
        
        
        // ------------------Properties-----------------------

            
        // Instanciate a Event Catalog Singleton
        public EventCatalogSingleton EventCatalogSingleton { get; set; }

        public ObservableCollection<Event> EventsCollection { get; set; }

        public EventHandler eventHandler { get; set; }
            
        public RelayCommand CreateEventCommand { get; set; }


        // Properties for Event

        public string Name { get; set; }
        public string Place { get; set; }
        public string Description { get; set; }

        public DateTime Date { get; set; }

        public DateTime Time { get; set; }


        // ------------------Constructor---------------------
        public EventViewModel()
        {
            _eventCatalogSingleton = EventCatalogSingleton.Instance;
            EventsCollection = _eventCatalogSingleton.GetEventCatalogSingleton();
            eventHandler = new EventHandler(this);
            CreateEventCommand = new RelayCommand(eventHandler.CreateEvent());
        }   

    }
}
