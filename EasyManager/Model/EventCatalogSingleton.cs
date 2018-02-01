using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyManager.Model
{
    class EventCatalogSingleton
    {
        private static EventCatalogSingleton instance;

        private EventCatalogSingleton() { }

        public static EventCatalogSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new EventCatalogSingleton();
                }
                return instance;
            }
        }

        //ObservableCollection<Event> EventCollection = new
    }
}
