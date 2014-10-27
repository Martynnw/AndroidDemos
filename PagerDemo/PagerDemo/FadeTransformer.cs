using System;
using Android.Support.V4.View;
using Android.Views;
using Android.Widget;

namespace PagerDemo
{
	/// <summary>
	/// This FadeTransformer fades fragments in and out as they are swiped.
	/// </summary>
	public class FadeTransformer : Java.Lang.Object, ViewPager.IPageTransformer
	{
		private float MinAlpha = 0.3f; // Minimum alpha value.

		public void TransformPage(View view, float position)
		{
			if (position < -1 || position > 1) 
			{
				view.Alpha = 0; // The view is offscreen.
			} 
			else 
			{
				float scale = 1 - Math.Abs (position); // The scale should be 1 at position 0, and 0 at positions 1 and -1
				float alpha = MinAlpha + (1 - MinAlpha) * scale; // Calculate the alpha value
				view.Alpha = alpha; // Apply the value to the view

				view.FindViewById<TextView> (Resource.Id.textView1).Text = string.Format ("Position: {0}\r\nAlpha: {1}", position, alpha);
			}
		}
	}
}

