using Android.App;
using Android.Content.PM;
using Android.OS;

namespace FormaresMaui
{
    [Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, LaunchMode = LaunchMode.SingleTop, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
    public class MainActivity : MauiAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            //Changes the NavigationBar and StatusBar  Colors in Android
            Window.SetStatusBarColor(Android.Graphics.Color.LightGreen);
            //Window.SetNavigationBarColor(Android.Graphics.Color.White);

            base.OnCreate(savedInstanceState);
        }
    }
}
