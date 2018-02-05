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
         
        // properties

        public ObservableCollection<Event> EventsCollection { get; set; }
            
        public RelayCommand CreateEventCommand { get; set; }

        public EventViewModel()
        {
           

        }

    }
}
