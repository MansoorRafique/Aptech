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

using Windows.UI.Notifications;
using Windows.Data.Xml.Dom;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace TilesInStoreApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();


            //This line enable tile notification
            TileUpdateManager.CreateTileUpdaterForApplication().EnableNotificationQueue(true);

            //This line extract the xml default code for Template TileSquareBlock

            //<tile>
            //  <visual>
            //    <binding template="TileSquareBlock">
            //      <text id="1">Text Field 1 (block text)</text>
            //      <text id="2">Text Field 2</text>
            //    </binding>  
            //  </visual>
            //</tile>



            //XmlDocument doc = TileUpdateManager.GetTemplateContent(TileTemplateType.TileSquareBlock);

            //doc.GetElementsByTagName("text")[0].InnerText = "88";
            //doc.GetElementsByTagName("text")[1].InnerText = "Gulraiz";

          
            XmlDocument tileDoc = TileUpdateManager.GetTemplateContent(TileTemplateType.TileSquarePeekImageAndText01);

            tileDoc.GetElementsByTagName("text")[0].InnerText = "Zeeshan";
            tileDoc.GetElementsByTagName("text")[1].InnerText = "Affan";
            tileDoc.GetElementsByTagName("text")[2].InnerText = "Salman";
            tileDoc.GetElementsByTagName("text")[3].InnerText = "Nahal";

            ((XmlElement)tileDoc.GetElementsByTagName("image")[0]).SetAttribute("src", "ms-appx:///Assets/flower.jpg");
            TileNotification tileNot = new TileNotification(tileDoc);
            TileUpdateManager.CreateTileUpdaterForApplication().Update(tileNot);



            //Badge for Number

            XmlDocument badgeDoc1 = BadgeUpdateManager.GetTemplateContent(BadgeTemplateType.BadgeNumber);

            ((XmlElement)badgeDoc1.GetElementsByTagName("badge")[0]).SetAttribute("value", "14");

            BadgeNotification badgeNot1 = new BadgeNotification(badgeDoc1);
            BadgeUpdateManager.CreateBadgeUpdaterForApplication().Update(badgeNot1);


            //Badge for Glyoh

            XmlDocument badgeDoc2 = BadgeUpdateManager.GetTemplateContent(BadgeTemplateType.BadgeGlyph);

            ((XmlElement)badgeDoc2.GetElementsByTagName("badge")[0]).SetAttribute("value", "activity");

            BadgeNotification badgeNot2 = new BadgeNotification(badgeDoc2);
            BadgeUpdateManager.CreateBadgeUpdaterForApplication().Update(badgeNot2);


            //var timer1 = new DispatcherTimer();
            DispatcherTimer timer2 = new DispatcherTimer();
            timer2.Tick+=timer2_Tick;
            timer2.Interval = new TimeSpan(0, 0, 0, 10);
            timer2.Start();
        }

        void timer2_Tick(object sender, object e)
        {
            ToastNotification(); 
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void btnClickMe_Click_1(object sender, RoutedEventArgs e)
        {

           
            //<toast> 
            //    <visual> 
            //        <binding template="ToastImageAndText01">
            //            <image id=”1” src=""/> 
            //            <text id=”1”></text>
            //      </binding> 
            //    </visual>
            // </toast>


            ToastNotification();


            //Scheduled Toast Notification

            //double seconds = 5;

            //DateTime dueTime = DateTime.Now.AddSeconds(seconds);

            //ScheduledToastNotification sNot = new ScheduledToastNotification(toastDoc, dueTime);
            //ToastNotificationManager.CreateToastNotifier().AddToSchedule(sNot);

        }

        private static void ToastNotification()
        {
            XmlDocument toastDoc = ToastNotificationManager.GetTemplateContent(ToastTemplateType.ToastImageAndText01);

            XmlNodeList myToastTextElements = toastDoc.GetElementsByTagName("text");
            myToastTextElements[0].AppendChild(toastDoc.CreateTextNode("This is sample toast notification"));

            XmlNodeList myToastImageAttributes = toastDoc.GetElementsByTagName("image");
            ((XmlElement)myToastImageAttributes[0]).SetAttribute("src", "msappx:///images/sample.png");

            ToastNotification myToast = new ToastNotification(toastDoc);
            ToastNotificationManager.CreateToastNotifier().Show(myToast);
        }
    }
}
