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
    [Activity(Label = "PagerDemo", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private ViewPager viewPager;
        private PagerAdapter pagerAdapter;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            this.SetContentView(Resource.Layout.Main);
            
            pagerAdapter = new ScreenSlidePagerAdapter(this.FragmentManager);

            viewPager = this.FindViewById<ViewPager>(Resource.Id.pager);
            viewPager.SetPageTransformer(true, new WheelPageTransformer());
            viewPager.Adapter = pagerAdapter;
        }
    }
}

