using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Notifications;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace WindowsStoreApp_Tiles
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            //this.InitializeComponent();
            //XmlDocument Document = TileUpdateManager.GetTemplateContent(TileTemplateType.TileSquare150x150PeekImageAndText01);
            //Document.GetElementsByTagName("text")[0].InnerText = "Windows";
            //((XmlElement)Document.GetElementsByTagName("image")[0]).SetAttribute("src", "ms-appx:///Assets/car.jpg");
            //TileNotification not = new TileNotification(Document);
            //TileUpdateManager.CreateTileUpdaterForApplication().Update(not); 

            this.InitializeComponent();
            XmlDocument Document = TileUpdateManager.GetTemplateContent(TileTemplateType.TileWide310x150PeekImageAndText01);
            Document.GetElementsByTagName("text")[0].InnerText = "Mercedes";
            ((XmlElement)Document.GetElementsByTagName("image")[0]).SetAttribute("src", "ms-appx:///Assets/wide.jpg");
            TileNotification not = new TileNotification(Document);
            TileUpdateManager.CreateTileUpdaterForApplication().Update(not); 
        }
    }
}
