using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FileAccessDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var fileAccess = DependencyService.Get<IFileAccess>();
            var menuItems = fileAccess.GetSpecialFolders().Select(x => new { Text = x.Key, Detail = x.Value });
            FolderList.ItemsSource = menuItems;
        }
    }
}
