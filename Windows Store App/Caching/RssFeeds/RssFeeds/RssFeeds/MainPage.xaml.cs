using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Networking.Connectivity;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Web.Syndication;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace RssFeeds
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
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            NetworkInformation.NetworkStatusChanged += NetworkInformation_NetworkStatusChanged;
            RefreshNetwork();
        }
        void NetworkInformation_NetworkStatusChanged(object sender)
        {
            RefreshNetwork();
        }
        void RefreshNetwork()
        {
            ConnectionProfile profile = NetworkInformation.GetInternetConnectionProfile();
            StringBuilder str = new StringBuilder();
            if (profile != null)
            {
                str.Append("Network Name: ");
                str.Append(profile.GetNetworkNames()[0]);
                str.Append("Network Type: ");
                str.Append(profile.GetNetworkConnectivityLevel());
            }
            else
                str.Append("Disconnected");
            networkInformatin.Text = str.ToString();
        }
        

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(link.Text.Trim()) && Uri.IsWellFormedUriString(link.Text.Trim(),UriKind.Absolute))
            {
                SyndicationClient client = new SyndicationClient();
                var feed = await client.RetrieveFeedAsync(new Uri(link.Text.Trim(), UriKind.Absolute));
                listItem.Items.Clear();
                foreach (var item in feed.Items)
                {
                    listItem.Items.Add(item);
                }
            }
            else
            {
                var message = new MessageDialog("Please put the wellformed string.");
            }
            
        }

        private void listItem_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SyndicationItem item = listItem.SelectedItem as SyndicationItem;
            title.Text = item.Title.Text;
            websummary.NavigateToString(item.Summary.Text);
        }
    }
}
