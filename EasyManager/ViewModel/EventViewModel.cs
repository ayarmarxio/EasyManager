using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyManager.Model;

namespace EasyManager.ViewModel
{
    class EventViewModel
    {
        private EventCatalogSingleton _eventCatalogSingleton;

        // properties

        public EventCatalogSingleton EventCatalogSingleton { get; set; }

        public ObservableCollection<Event> EventsCollection { get; set; }

        public EventHandler eventHandler { get; set; }
            
        public RelayCommand CreateEventCommand { get; set; }

        public EventViewModel()
        {
            _eventCatalogSingleton = EventCatalogSingleton.Instance;
            EventsCollection = _eventCatalogSingleton.GetEventCatalogSingleton();
            CreateEventCommand = new RelayCommand(eventHandler.CreateEvent());
        }   

    }
}
