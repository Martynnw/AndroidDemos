using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.ComponentModel;

namespace AbsoluteLayoutDemo
{
	public partial class DemoPage : ContentPage
	{
		public DemoPage()
		{
			InitializeComponent();

			var viewModel = new DemoPageViewModel();

			viewModel.PropertyChanged += this.ViewModel_PropertyChanged;

			this.BindingContext = viewModel;
		}

		private void ViewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			var viewModel = (DemoPageViewModel)sender;
			AbsoluteLayout.SetLayoutBounds(this.BoundsBox, new Rectangle(viewModel.X, viewModel.Y, viewModel.Width, viewModel.Height));

			viewModel.SetMinMaxs();

			AbsoluteLayoutFlags flags = AbsoluteLayoutFlags.None;

			if (viewModel.FlagsAll)
			{
				flags = flags | AbsoluteLayoutFlags.All;
			}

			if (viewModel.FlagsXProp)
			{
				flags = flags | AbsoluteLayoutFlags.XProportional;
			}

			if (viewModel.FlagsYProp)
			{
				flags = flags | AbsoluteLayoutFlags.YProportional;
			}

			if (viewModel.FlagsSizeProp)
			{
				flags = flags | AbsoluteLayoutFlags.SizeProportional;
			}

			if (viewModel.FlagsWidthProp)
			{
				flags = flags | AbsoluteLayoutFlags.SizeProportional;
			}

			if (viewModel.FlagsHeightProp)
			{
				flags = flags | AbsoluteLayoutFlags.HeightProportional;
			}

			if (viewModel.FlagsPositionProp)
			{
				flags = flags | AbsoluteLayoutFlags.PositionProportional;
			}

			AbsoluteLayout.SetLayoutFlags(this.BoundsBox, flags);
		}
	}
}

