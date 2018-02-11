using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Email.DataProvider;
using Windows.ApplicationModel.VoiceCommands;
using Windows.Security.Cryptography.Core;
using Windows.UI.Xaml;
using EasyManager.Model;
using Windows.UI.Popups;
using EasyManager.Converter;


namespace EasyManager.ViewModel
{
    public class EventHandlerClass
    {
        private EventViewModel _eventViewModel;

        private DateTimeConverter _dateTimeConverter = new DateTimeConverter();
        

        public Event CreatedEvent { get; set; }

      
        public EventHandlerClass(EventViewModel EventViewModel)
        {
            _eventViewModel = EventViewModel;
            
        }

        
        public void CreateEvent()
        {
            DateTimeOffset GotTime = _eventViewModel.Date;
            
            
                       
            Event createdEvent = new Event(
                _eventViewModel.Name,
                _eventViewModel.Place,
                _eventViewModel.Description,
                _eventViewModel.Date,
                _eventViewModel.Time                 
                );

           _eventViewModel.EventCatalogSingleton.DoAddEvent(createdEvent);

        }

        public async void DeleteEvent() 
        {
            if (_eventViewModel.SelectedEvent == null)
            {
                var messageDialog = new MessageDialog ("You need to select an Event in order to delete it");
                await messageDialog.ShowAsync();
            }

            else
            {
                _eventViewModel.EventCatalogSingleton.DoDeleteEvent(_eventViewModel.SelectedEvent);
            }
           
        }
    }
}





