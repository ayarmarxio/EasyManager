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

            private ObservableCollection<Event> eventCollection;

            private EventCatalogSingleton()
            {
                eventCollection = new ObservableCollection<Event>()
                {
                    new Event("Salsa", "Rostorv", "Very very funny activity", new DateTime (2017, 01, 11), new DateTime (2017, 01, 14)),
                    new Event("Fitness", "Copenhagen", "Not that funny activity", new DateTime (2017, 01, 11), new DateTime (2017, 01, 14)),
                    new Event("Ballet", "Holbæk", "Very dangerous activity", new DateTime (2017, 01, 11), new DateTime (2017, 01, 14)),
                };
            }

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

            public void DoAddEvent(Event addedEvent)
            {
                 eventCollection.Add(addedEvent);
            }


            

            
            
            

    }
}
