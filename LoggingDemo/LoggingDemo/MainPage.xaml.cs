using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace LoggingDemo
{
    public partial class MainPage : ContentPage
    {
        private static ILogger logger = DependencyService.Get<ILogManager>().GetLog();

        public MainPage()
        {
            InitializeComponent();
        }

        private void Trace_Clicked(Object sender, EventArgs args)
        {
            logger.Trace("Trace Clicked");
        }

        private void Debug_Clicked(Object sender, EventArgs args)
        {
            logger.Debug("Debug Clicked");
        }

        private void Info_Clicked(Object sender, EventArgs args)
        {
            logger.Info("Info Clicked");
        }

        private void Warn_Clicked(Object sender, EventArgs args)
        {
            logger.Warn("Warn Clicked");
        }

        private void Error_Clicked(Object sender, EventArgs args)
        {
            logger.Error("Error Clicked");
        }

        private void Fatal_Clicked(Object sender, EventArgs args)
        {
            logger.Fatal("Fatal Clicked");
        }
    }
}
