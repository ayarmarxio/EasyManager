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

        private DateTimeConverter _dateTimeConverter;
        
        public Event CreatedEvent { get; set; }
        
        public EventHandlerClass(EventViewModel EventViewModel)
        {
            _eventViewModel = EventViewModel;
        }
        
        public void CreateEvent()
        {
            _dateTimeConverter = new DateTimeConverter();
            
            DateTimeOffset changedDate = _dateTimeConverter.DateToDate(_eventViewModel.Date);
            DateTimeOffset changedTime = _dateTimeConverter.DateToTime(_eventViewModel.Time);

            
            Event createdEvent = new Event(
                _eventViewModel.Name,
                _eventViewModel.Place,
                _eventViewModel.Description,
                changedDate,
                changedTime                
                );

           _eventViewModel.EventCatalogSingleton.DoAddEvent(createdEvent);
           _eventViewModel.EventCatalogSingleton.SaveEvents();

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





