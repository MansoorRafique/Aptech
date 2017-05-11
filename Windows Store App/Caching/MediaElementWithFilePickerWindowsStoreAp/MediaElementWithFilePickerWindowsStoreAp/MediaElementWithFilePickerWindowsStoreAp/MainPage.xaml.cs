using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage.Pickers;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace MediaElementWithFilePickerWindowsStoreAp
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

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var openPicker = new FileOpenPicker();
            openPicker.SuggestedStartLocation = PickerLocationId.VideosLibrary;
            openPicker.FileTypeFilter.Add(".wma");
            openPicker.FileTypeFilter.Add(".mp4");
            var file = await openPicker.PickSingleFileAsync();

            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            MediaElement.SetSource(stream, "");
            MediaElement.Play();
        }

        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            MediaElement.DefaultPlaybackRate = 1;
            MediaElement.Play();
        }

        private void btnPause_Click(object sender, RoutedEventArgs e)
        {
            MediaElement.Pause();
        }

        private void btnForward_Click(object sender, RoutedEventArgs e)
        {

            MediaElement.PlaybackRate = 2;
        }

        

        private void btnBackward_Click(object sender, RoutedEventArgs e)
        {
            //MediaElement.DefaultPlaybackRate = -1;
            MediaElement.PlaybackRate = -2;
        }
    }
}
