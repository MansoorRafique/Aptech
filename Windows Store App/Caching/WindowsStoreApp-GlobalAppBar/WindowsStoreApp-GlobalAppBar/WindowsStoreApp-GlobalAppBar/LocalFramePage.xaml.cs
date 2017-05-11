using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace WindowsStoreApp_GlobalAppBar
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LocalFramePage : Page
    {
        public LocalFramePage()
        {
            this.InitializeComponent();
        }


        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            this.localFrame.Navigate(typeof(MainPage));
        }


        private void btnAboutUs_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.localFrame.Navigate(typeof(AboutUs));
            this.commandBar.IsOpen = false;
        }

        private void btnContactUs_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.localFrame.Navigate(typeof(Contacts));
            this.commandBar.IsOpen = false;
        }

        private void btnServices_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.localFrame.Navigate(typeof(Services));
            this.commandBar.IsOpen = false;
        }

        private void btnHome_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.localFrame.Navigate(typeof(MainPage));
            this.commandBar.IsOpen = false;
        }
        
        private void btnBack_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if(this.localFrame !=null && this.localFrame.CanGoBack)
            {
                this.localFrame.GoBack();
                this.commandBar.IsOpen = false;
            }
        }

        private void btnForward_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (this.localFrame != null && this.localFrame.CanGoForward)
            {
                this.localFrame.GoForward();
                this.commandBar.IsOpen = false;
            }
        }
    }
}
