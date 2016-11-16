using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;

[assembly: Dependency(typeof(Martynnw.ActivityResultDemo.Droid.Phonebook))]
namespace Martynnw.ActivityResultDemo.Droid
{
    public class Phonebook : IPhonebook
    {
        public Task<string> GetContactName()
        {
            var intent = new Intent(Forms.Context, typeof(PhonebookActivity));
            Forms.Context.StartActivity(intent);

            var tcs = new TaskCompletionSource<string>();
            EventHandler handler = null;

            handler = (sender, args) =>
            {
                PhonebookActivity.ContactResultHandler -= handler;
                tcs.SetResult(((PhonebookActivity)sender).ContactName);
            };

            PhonebookActivity.ContactResultHandler += handler;

            return tcs.Task;
        }
    }
}