using FormaresMaui.Infrastructure.Licenses;
using Microsoft.Extensions.Configuration;
using System.Text.Json;

namespace FormaresMaui
{
    public partial class App : Application
    {
        public App()
        {
            string SyncFusionKey = LicenseKey.GetSyncFusionKey();
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(SyncFusionKey);                       

            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
