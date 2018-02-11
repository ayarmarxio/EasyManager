using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Threading.Tasks;
using Windows.Storage;
using EasyManager.Model;
using Windows.UI.Popups;
using Newtonsoft.Json;


namespace EasyManager.Persistency
{
    public class PersistencyService
    {
        private static string _eventFileName;
        private static string _eventsJsonString;
       

        public PersistencyService()
        {
            
        }

        public static async void SaveEventsAsJsonAsync(ObservableCollection<Event> events)
        {
            _eventFileName = "EventAsJson.dat";
            _eventsJsonString = JsonConvert.SerializeObject(events);
            SerializeEventsFileAsync(_eventsJsonString, _eventFileName);
        }
        
            
        public static async Task<List<Event>> LoadEventsFromJasonAsync()
        {
            string eventsJasonString = await DeSerializeEventsFileAsync(_eventFileName);
                if (eventsJasonString != null)
            {
                return (List<Event>)JsonConvert.DeserializeObject(_eventsJsonString, typeof(List<Event>));
            }

            else
            {
                return null;
            }
        }
   
        

        public static async void SerializeEventsFileAsync(string eventsString, string fileName)
        {
            StorageFile localFile = await ApplicationData.Current.LocalFolder.CreateFileAsync(fileName, CreationCollisionOption.ReplaceExisting);

            await FileIO.WriteTextAsync(localFile, eventsString);

        }


        public static async Task<string> DeSerializeEventsFileAsync(String fileName)
        {
            try
            {
                   StorageFile localFile = await ApplicationData.Current.LocalFolder.GetFileAsync(fileName);
                   return await FileIO.ReadTextAsync(localFile);
            }

            catch (FileNotFoundException ex)
            {
                    var messageDialog = new MessageDialog("File of events not found. Login for the first time?");
                    await messageDialog.ShowAsync();
                    return null;
            }
       }
    }
 }



    

    


