using System;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using ButtonCustomRenderer;
using ButtonCustomRenderer.Droid;

[assembly: ExportRendererAttribute (typeof(CustomButton), typeof(CustomButtonRenderer))]
namespace ButtonCustomRenderer.Droid
{
	public class CustomButtonRenderer : ButtonRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
		{
			base.OnElementChanged(e);

			if (Control != null)
			{
				Control.SetAllCaps(false);
			}
		}
	}
}

