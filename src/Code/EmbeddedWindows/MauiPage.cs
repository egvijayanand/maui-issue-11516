using CommunityToolkit.Maui.Markup;
using Microsoft.Maui.Controls;

namespace EmbeddedWindows
{
	public class MauiPage : ContentPage
	{
		public MauiPage()
		{
			BindingContext = new MainViewModel();
			Content = new Grid
			{
				Children =
				{
					new Button().Center()
								.Bind(Button.TextProperty, nameof(MainViewModel.CountText))
								.Bind(nameof(MainViewModel.CountCommand))
				}
			};
		}
	}
}
