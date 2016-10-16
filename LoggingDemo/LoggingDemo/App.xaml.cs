using Xamarin.Forms;

namespace LoggingDemo
{
    public partial class App : Application
    {
        private static ILogger logger = DependencyService.Get<ILogManager>().GetLog();

        public App()
        {
            InitializeComponent();

            logger.Info("App Start");
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
