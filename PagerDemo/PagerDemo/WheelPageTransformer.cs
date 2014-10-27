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
    internal class WheelPageTransformer : Java.Lang.Object, ViewPager.IPageTransformer
    {
        private const float MaxAngle = 30F;

        public void TransformPage(View view, float position)
        {
			if (position < -1 || position > 1) 
			{
				view.Alpha = 0; // The view is offscreen.
			} 
			else 
            {
				view.Alpha = 1; 

				view.PivotY = view.Height / 2; // The Y Pivot is halfway down the view.

				// The X pivots need to be on adjacent sides.
                if (position < 0)
                {
                    view.PivotX = view.Width;
                }
                else
                {
                    view.PivotX = 0;
                }

                view.RotationY = MaxAngle * position; // Rotate the view.

				view.FindViewById<TextView> (Resource.Id.textView1).Text = string.Format ("Position: {0}\r\nPivotX: {1}\r\nRotationY {2}", position, view.PivotX, view.RotationY);
            }
        }
    }
}