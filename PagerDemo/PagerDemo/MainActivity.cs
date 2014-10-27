using System;
using System.Collections.Generic;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Support.V4.View;

namespace PagerDemo
{
    [Activity(Label = "PagerDemo", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : ListActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

			List<String> demos = new List<string> { "Basic", "Fade", "Scale", "Wheel", "Sink & Slide" };
			this.ListAdapter = new ArrayAdapter<String> (this, Android.Resource.Layout.SimpleListItem1, demos );
        }

		protected override void OnListItemClick (ListView l, View v, int position, long id)
		{
			Intent intent = new Intent (this, typeof(PagerActivity));
			intent.PutExtra (PagerActivity.PAGERTYPE, position);
			this.StartActivity (intent);
		}
    }
}

