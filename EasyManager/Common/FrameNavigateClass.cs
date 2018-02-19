using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace EasyManager.Common
{
    class FrameNavigateClass
    {
        public void ActivateFrameNavigation(Type type, Object currentUser)
        {
            var frame = (Frame)Window.Current.Content;
            frame.Navigate(type, currentUser);
            Window.Current.Content = frame;
            Window.Current.Activate();
        }
    }
}
