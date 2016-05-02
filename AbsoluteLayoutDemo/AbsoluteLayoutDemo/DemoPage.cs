using System;

using Xamarin.Forms;

namespace AbsoluteLayoutDemo
{
	public class DemoPage : ContentPage
	{
		public DemoPage()
		{
			Content = new StackLayout
			{
				Children = {
					new Label { Text = "Hello ContentPage" }
				}
			};
		}
	}
}


