using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyManager.Model;

namespace EasyManager.ViewModel
{
    public class EventHandler
    {
        public EventCatalogSingleton EventCatalogSingleton { get; set; }

        public EventHandler()
        {
            
        }

        public void CreateEvent(Event AddedEvent)
        {
            EventCatalogSingleton.DoAddEvent(AddedEvent);
        }
    }
}





