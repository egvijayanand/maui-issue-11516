using Microsoft.AspNetCore.Components.WebView.Maui;
using Microsoft.Maui.Platform;
using VijayAnand.MauiBlazor.Markup;

namespace EmbeddedWindows.WinUI
{
	public partial class MainWindow
	{
		public MainWindow()
		{
			InitializeComponent();
			Content = new BlazorWebView().Configure("wwwroot/index.html", "/counter", ("#app", typeof(Main), null))
										 .ToPlatform(new MauiContext(MauiWinUIApplication.Current.Services));
		}
	}
}
