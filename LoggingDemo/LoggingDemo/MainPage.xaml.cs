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
            logger.Trace("Debug Clicked");
        }

        private void Info_Clicked(Object sender, EventArgs args)
        {
            logger.Trace("Info Clicked");
        }

        private void Warn_Clicked(Object sender, EventArgs args)
        {
            logger.Trace("Warn Clicked");
        }

        private void Error_Clicked(Object sender, EventArgs args)
        {
            logger.Trace("Error Clicked");
        }

        private void Fatal_Clicked(Object sender, EventArgs args)
        {
            logger.Trace("Fatal Clicked");
        }
    }
}
