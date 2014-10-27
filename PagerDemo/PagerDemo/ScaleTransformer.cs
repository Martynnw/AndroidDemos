using System;
using Android.Support.V4.View;
using Android.Views;
using Android.Widget;

namespace PagerDemo
{
	/// <summary>
	/// This ScaleTransformer zooms fragments in and out as they are swiped.
	/// </summary>
	public class ScaleTransformer : Java.Lang.Object, ViewPager.IPageTransformer
	{
		private float MinScale = 0.5f; // Minimum scale value.

		public void TransformPage(View view, float position)
		{
			if (position < -1 || position > 1) 
			{
				view.Alpha = 0; // The view is offscreen.
			} 
			else 
			{
				view.Alpha = 1;

				// Scale the view.
				float scale = 1 - Math.Abs (position) * (1 - MinScale);
				view.ScaleX = scale;
				view.ScaleY = scale;

				// Set the X Translation to keep the views close together.
				float xMargin = view.Width * (1 - scale) / 2;

				if (position < 0) 
				{
					view.TranslationX = xMargin  / 2;
				} 
				else 
				{
					view.TranslationX = -xMargin  / 2;
				}

				view.FindViewById<TextView> (Resource.Id.textView1).Text = string.Format ("Position: {0}\r\nScale: {1}", position, scale);
			}
		}
	}
}

