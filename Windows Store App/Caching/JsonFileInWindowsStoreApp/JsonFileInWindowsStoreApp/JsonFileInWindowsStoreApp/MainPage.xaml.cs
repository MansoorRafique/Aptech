using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Serialization.Json;
using System.Text;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;



// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace JsonFileInWindowsStoreApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        public MainPage()
        {
            this.InitializeComponent();
            abc();
        }

        public async void abc()
        {
            StorageFolder folder = Windows.ApplicationModel.Package.Current.InstalledLocation;
            //StorageFile Stfile = await folder.GetFileAsync("Sample.json");
            var json = await Windows.Storage.FileIO.ReadTextAsync(Stfile);
            DataContractJsonSerializer dcjs = new DataContractJsonSerializer(typeof(List<example>));
            MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(json));
            List<example> obj = (List<example>)dcjs.ReadObject(ms);
            cb.DataContext = obj;
            
        }


        public IStorageFile Stfile { get; set; }
    }
}
