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

namespace EasyManager.ViewModel
{
    class EventHandler
    {
        private EventViewModel _eventViewModel;

        public Event CreatedEvent { get; set; }
   
        
        public EventHandler(EventViewModel EventViewModel)
        {
            _eventViewModel = EventViewModel;
        }

        public void CreateEvent()
        {
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





