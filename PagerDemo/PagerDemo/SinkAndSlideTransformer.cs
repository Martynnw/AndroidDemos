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

using Android.Support.V4.View;

namespace PagerDemo
{
    internal class SinkAndSlideTransformer : Java.Lang.Object, ViewPager.IPageTransformer
    {
        public void TransformPage(View view, float position)
        {
			if (position < -1 || position > 1) 
			{
				view.Alpha = 0; // The view is offscreen.
			} 
			else 
			{
				view.Alpha = 1;

				if (position < 0) 
				{
					// 'Sink' the view if it's to the left.
					// Scale the view.
					view.ScaleX = 1 - Math.Abs (position);
					view.ScaleY = 1 - Math.Abs (position);

					// Set the translationX to keep the view in the middle.
					view.TranslationX = view.Width * Math.Abs (position);
				} 
			}
        }
    }
}