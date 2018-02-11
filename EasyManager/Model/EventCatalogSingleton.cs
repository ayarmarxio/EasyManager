using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyManager.Persistency;

namespace EasyManager.Model
{
    public class EventCatalogSingleton
    {
            private static EventCatalogSingleton instance;

            private ObservableCollection<Event> eventCollection;

      
            private EventCatalogSingleton()
            {
                eventCollection = new ObservableCollection<Event>()
                {
                    new Event("Salsa", "Rostorv", "Very very funny activity", new DateTimeOffset(), new DateTimeOffset()),
                    new Event("Fitness", "Copenhagen", "Not that funny activity", new DateTimeOffset(), new DateTimeOffset()),
                    new Event("Ballet", "Holbæk", "Very dangerous activity", new DateTimeOffset(), new DateTimeOffset()),
                    new Event("Hockey", "Lejre", "Lovely and passionate activity", new DateTimeOffset(), new DateTimeOffset()),
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

            // If you need to retrieve the Event Catalog Singleton as a Observable Collecion

            public ObservableCollection<Event> GetEventCatalogSingleton()
                {
                    return eventCollection;
                } 
            
            //   Add an event to the collection.

            public void DoAddEvent(Event addedEvent)
            {
                 eventCollection.Add(addedEvent);
            }

            public void DoDeleteEvent(Event deletedEvent)
            {
                eventCollection.Remove(deletedEvent);
            }

            // Serialization Methods

            public void SaveEvents(ObservableCollection<Event> savedAsJsonObservableCollection)
            {
                PersistencyService.SaveEventsAsJsonAsync(savedAsJsonObservableCollection);
            }

            public async void LoadEvents()
            {
                await PersistencyService.LoadEventsFromJasonAsync();
            }
    }
}
