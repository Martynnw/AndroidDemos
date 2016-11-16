using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Martynnw.ActivityResultDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void SelectContact_OnClicked(object sender, EventArgs e)
        {
            var phonebook = DependencyService.Get<IPhonebook>();
            var contact = await phonebook.GetContactName();

            await DisplayAlert("Contact Selected", contact, "Nice!");
        }
    }
}
