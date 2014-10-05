using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace ListViewDemo
{
    [Activity(Label = "ListView Demo", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : ListActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            string[] items = new string[] { "String Adapter & Simple Layout", "Custom Adapter & Layout", "Alternating Layouts", "Items with Buttons", "Items with CheckBoxes", "Custom Layout & Updating Data" };
            ListAdapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, items);
        }

        protected override void OnListItemClick(ListView l, View v, int position, long id)
        {
            base.OnListItemClick(l, v, position, id);

            switch (position)
            {
                case 0:
                    this.StartActivity(new Intent(this, typeof(SimpleAdapterActivity)));
                    break;

                case 1:
                    this.StartActivity(new Intent(this, typeof(CustomAdapterActivity)));
                    break;

                case 2: 
                    this.StartActivity(new Intent(this, typeof(AlternatingLayoutActivity)));
                    break;

                case 3:
                    this.StartActivity(new Intent(this, typeof(ButtonActivity)));
                    break;

                case 4:
                    this.StartActivity(new Intent(this, typeof(CheckBoxActivity)));
                    break;

                case 5:
                    this.StartActivity(new Intent(this, typeof(CustomLayoutActivity)));
                    break;
            }
        }
    }
}

