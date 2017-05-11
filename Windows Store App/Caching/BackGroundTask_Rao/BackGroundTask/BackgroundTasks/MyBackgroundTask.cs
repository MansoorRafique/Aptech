using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Background;
using Windows.UI.Notifications;

namespace BackgroundTasks
{
    public sealed class MyBackgroundTask : IBackgroundTask
    {
        public void Run(IBackgroundTaskInstance taskInstance)
        { 
            //Background task Logic Building//
            UpdateNetworkStatusAndTime();
        }

        private static void UpdateNetworkStatusAndTime()
        {
            var tileContent = TileUpdateManager.GetTemplateContent(TileTemplateType.TileSquareText02);
            
            tileContent.GetElementsByTagName("text")[0].InnerText = "ABC";
            tileContent.GetElementsByTagName("text")[1].InnerText = DateTime.Now.ToString("MM/dd/yyyy");
            tileContent.GetElementsByTagName("text")[2].InnerText = DateTime.Now.ToString("HH/mm/ss");

            var notification = new TileNotification(tileContent);
            var updater = TileUpdateManager.CreateTileUpdaterForApplication();
            updater.Update(notification);
        }
    }
}
