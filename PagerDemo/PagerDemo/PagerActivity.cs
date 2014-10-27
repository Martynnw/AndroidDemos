using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Support.V4.View;

namespace PagerDemo
{
    [Activity(Label = "PagerDemo", Icon = "@drawable/icon")]
    public class PagerActivity : Activity
    {
		public const string PAGERTYPE = "PagerType";

        private ViewPager viewPager;
        private PagerAdapter pagerAdapter;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            this.SetContentView(Resource.Layout.PagerActivity);
            
            pagerAdapter = new DemoPagerAdapter(this.FragmentManager);

            viewPager = this.FindViewById<ViewPager>(Resource.Id.pager);
            viewPager.Adapter = pagerAdapter;
			this.SetPageTransformer ();
        }

		private void SetPageTransformer()
		{
			switch (this.Intent.GetIntExtra(PAGERTYPE, 0))
			{
			    case 1:
			    	viewPager.SetPageTransformer (true, new FadeTransformer ()); 
			    	break;

				case 2:
					viewPager.SetPageTransformer (true, new ScaleTransformer ());
					break;

				case 3:
					viewPager.SetPageTransformer (true, new WheelPageTransformer ());
					break;

				case 4:
					viewPager.SetPageTransformer (false, new SinkAndSlideTransformer ());
					break;
			}
		}
    }
}

