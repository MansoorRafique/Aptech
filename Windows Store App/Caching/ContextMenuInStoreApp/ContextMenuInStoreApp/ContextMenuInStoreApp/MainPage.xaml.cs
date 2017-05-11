using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ContextMenuInStoreApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void Grid_RightTapped(object sender, RightTappedRoutedEventArgs e)
        {
            var menu = new PopupMenu();
            menu.Commands.Add(new UICommand("Yes", command =>
            {

            }));
            menu.Commands.Add(new UICommandSeparator());
            menu.Commands.Add(new UICommand("No", command =>
            {

            }));
            menu.Commands.Add(new UICommand("Hi", command =>
            {

            }));
            menu.Commands.Add(new UICommandSeparator());
            menu.Commands.Add(new UICommand("Hello", command =>
            {

            }));
            var point = e.GetPosition(null);
            await menu.ShowForSelectionAsync(new Rect(point, new Size(0, 0)));
        }
    }
}
