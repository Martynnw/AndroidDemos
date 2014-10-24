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

        public void TransformPage(View page, float position)
        {
            int pageWidth = page.Width;
            int pageHeight = page.Height;

            if (position < -1)
            {
                page.Alpha = 0; // Off screen to the left.
            }
            else if (position <= 1)
            {/*
                float scaleFactor = Math.Max(MinScale, 1 - Math.Abs(position));
                float vertMargin = pageHeight * (1 - scaleFactor) / 2;
                float horzMargin = pageWidth * (1 - scaleFactor) / 2;

                if (position < 0)
                {
                    page.TranslationX = horzMargin - vertMargin / 2;
                }
                else
                {
                    page.TranslationY = -horzMargin + vertMargin / 2;
                }

                page.ScaleX = scaleFactor;
                page.ScaleY = scaleFactor;

                page.Alpha = MinAlpha + (scaleFactor - MinScale) / (1 - MinScale) * (1 - MinAlpha);

                */
                page.PivotY = page.Height;

                float angle = position * MaxAngle;
                page.Rotation = angle;
            }
            else
            {
                page.Alpha = 0; // Off screen to the right.
            }
        }
    }
}