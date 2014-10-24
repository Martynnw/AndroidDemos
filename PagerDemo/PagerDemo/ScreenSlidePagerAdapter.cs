using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace PagerDemo
{
    internal class ScreenSlidePagerAdapter : Android.Support.V13.App.FragmentStatePagerAdapter
    {
        private const int PageCount = 5;

        public ScreenSlidePagerAdapter(FragmentManager fm) : base(fm)
        {
        }

        public override Fragment GetItem(int position)
        {
            return new PagerFragment();
        }

        public override int Count
        {
            get { return PageCount; }
        }
    }
}