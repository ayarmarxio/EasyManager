using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using EasyManager.Model;
using EasyManager.Common;

namespace EasyManager.ViewModel
{
   public class EventViewModel: NotifyPropertyClass
    {
        private EventCatalogSingleton _eventCatalogSingleton;

        // private EventHandler _eventHandler;

        // properties

        public EventCatalogSingleton EventCatalogSingleton { get; set; }

        public ObservableCollection<Event> EventsCollection { get; set; }

        private EventHandler _eventHandler;

        public RelayCommand CreateEventCommand { get; set; }

        public EventViewModel()
        {
            _eventCatalogSingleton = EventCatalogSingleton.Instance;
            EventsCollection = _eventCatalogSingleton.GetEventCatalogSingleton();
            _eventHandler = new EventHandler(this);
         

        }   

    }
}
