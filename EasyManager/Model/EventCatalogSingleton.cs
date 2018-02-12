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
                    new Event("Salsa", "Rostorv", "Very very funny activity", new DateTime(2018, 03,11), new TimeSpan(12,12,12)),
                    new Event("Fitness", "Copenhagen", "Not that funny activity", new DateTime(2018, 03,13), new TimeSpan(12,12,13)),
                    new Event("Ballet", "Holbæk", "Very dangerous activity", new DateTime(2018, 03,15), new TimeSpan(12,12,15)),
                    new Event("Hockey", "Lejre", "Lovely and passionate activity", new DateTime(2018, 03,17), new TimeSpan(12,12,17))
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
