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
        private const float MinScale = 0.85F;
        private const float MinAlpha = 0.5F;
        private const float MaxAngle = 30;

        public void TransformPage(View view, float position)
        {
            if (position < -1 || position > 1)
            {
                view.Alpha = 0;
            }
            else
            {
                view.PivotY = view.Height / 2;

                if (position < 0)
                {
                    view.PivotX = view.Width;
                }
                else
                {
                    view.PivotX = 0;
                }

                view.RotationY = 20F * position;
            }
        }
    }
}