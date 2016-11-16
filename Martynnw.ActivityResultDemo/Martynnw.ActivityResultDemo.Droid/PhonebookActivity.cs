using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

using Android.App;
using Android.Content;
using Android.Locations;
using Android.OS;
using Android.Provider;
using Android.Renderscripts;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Martynnw.ActivityResultDemo.Droid
{
    [Activity(Label = "PhonebookActivity")]
    public class PhonebookActivity : Activity
    {
        private const int RequestCodeSelectContact = 1;

        public string ContactName { get; private set; }

        public static EventHandler ContactResultHandler;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            if (bundle == null)
            {
                var intent = new Intent(Intent.ActionPick, ContactsContract.Contacts.ContentUri);

                if (intent.ResolveActivity(PackageManager) != null)
                {
                    StartActivityForResult(intent, RequestCodeSelectContact);
                }
                else
                {
#warning TODO need to set a result here
                }
            }
        }

        protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            ContactName = string.Empty;

            if (requestCode == RequestCodeSelectContact && resultCode == Result.Ok)
            {
                var uri = data.Data;

                string[] projection = new string[] { ContactsContract.ContactNameColumns.DisplayNamePrimary };

                var cursor = ContentResolver.Query(uri, projection, null, null, null);

                if (cursor.MoveToFirst())
                {
                    int columnIndex = cursor.GetColumnIndexOrThrow(ContactsContract.ContactNameColumns.DisplayNamePrimary);
                    ContactName = cursor.GetString(columnIndex);
                }
            }

            ContactResultHandler?.Invoke(this, new EventArgs());
            Finish();
        }
    }
}