using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

namespace GridViewAndListView
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BlankPage1 : Page
    {
        public BlankPage1()
        {
            this.InitializeComponent();
          
               List<Class1> list = new List<Class1>()
            {
             new Class1{Image_Name="Toyota Corolla",Image="Assets/download.png",Description="Try The fastest"},
             new Class1{Image_Name="Toyota Corolla",Image="Assets/1.jpgg",Description="Try The fastest"},
             new Class1{Image_Name="Toyota Corolla",Image="Assets/2.jpg",Description="Try The fastest"},
             new Class1{Image_Name="Toyota Corolla",Image="Assets/3.png",Description="Try The fastest"},
             new Class1{Image_Name="Toyota Corolla",Image="Assets/4.png",Description="Try The fastest"},
             new Class1{Image_Name="Toyota Corolla",Image="Assets/5.png",Description="Try The fastest"},
           };
           display.DataContext = list;
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }
    }
}
