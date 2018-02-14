
using System;
using System.Collections.ObjectModel;
using EasyManager.ViewModel;
using EasyManager.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EasyManagerTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange

            EventViewModel _eventViewModel = new EventViewModel();
            ObservableCollection<Event> _testobs = new ObservableCollection<Event>();
            _testobs = _eventViewModel.EventCatalogSingleton.GetEventCatalogSingleton();
            int beforeAdd = _testobs.Count;

            // Act

            _eventViewModel.eventHandler.CreateEvent();

            // Assert

            Assert.AreEqual(_testobs.Count, beforeAdd + 1);

        }
    }
}
