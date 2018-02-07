using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.VoiceCommands;
using Windows.UI.Xaml;
using EasyManager.Model;

namespace EasyManager.ViewModel
{
    class EventHandler
    {
        private EventViewModel _eventViewModel;
        private EventCatalogSingleton _eventCatalog;

        public Event CreatedEvent { get; set; }
        public EventCatalogSingleton EventCatalog { get; set; }
        
        public EventHandler( EventViewModel EventViewModel)
        {
            _eventViewModel = EventViewModel;
        }

        public void CreateEvent()
        {
             Event createdEvent = new Event (
                _eventViewModel.Name, 
                _eventViewModel.Place,
                _eventViewModel.Description, 
                _eventViewModel.Time, 
                _eventViewModel.Date
                );


            // EventCatalog.DoAddEvent(createdEvent);


            _eventViewModel.EventCatalogSingleton.DoAddEvent(CreatedEvent);

            
        }
    }
}





