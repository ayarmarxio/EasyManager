using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.VoiceCommands;
using EasyManager.Model;

namespace EasyManager.ViewModel
{
    class EventHandler
    {

        private EventViewModel _eventViewModelParameter;
        

        public EventHandler( EventViewModel EventViewModelParameter)
        {
            _eventViewModelParameter = EventViewModelParameter;
        }

        public void CreateEvent()
        {
           
            Event CreatedEvent = new Event(
                _eventViewModelParameter.Name, 
                _eventViewModelParameter.Place,
                _eventViewModelParameter.Description, 
                _eventViewModelParameter.Time, 
                _eventViewModelParameter.Date
                );
        }

        public void SetEvent()
        {
             
        }
    }
}





