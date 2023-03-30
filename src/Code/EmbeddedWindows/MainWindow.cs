using CommunityToolkit.Maui.Markup;
using Microsoft.Maui;
using Microsoft.Maui.Embedding;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Platform;
using Microsoft.UI.Xaml;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace EmbeddedWindows
{
	/// <summary>
	/// An empty window that can be used on its own or navigated to within a Frame.
	/// </summary>
	public class MainWindow : Window
	{
		public MainWindow()
		{
			var builder = MauiApp.CreateBuilder();
			builder.UseMauiEmbedding<MyApp>()
				   .UseMauiCommunityToolkitMarkup();
			var mauiApp = builder.Build();
			var mauiContext = new MauiContext(mauiApp.Services);
			var mauiPage = new MauiPage();
			Content = mauiPage.ToPlatform(mauiContext);
		}
	}
}
