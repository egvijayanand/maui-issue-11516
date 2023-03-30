using EmbeddedWindows.Data;
using Microsoft.Extensions.Logging;
using Microsoft.Maui.Embedding;

namespace EmbeddedWindows
{
	public static partial class MauiProgram
	{
		public static MauiApp CreateMauiApp()
		{
			var builder = MauiApp.CreateBuilder();
			builder.UseMauiEmbedding<App>()
				   .UseMauiCommunityToolkitMarkup()
				   .ConfigureFonts(fonts =>
				   {
					   fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
					   fonts.AddFont("OpenSans-SemiBold.ttf", "OpenSansSemiBold");
				   });

			builder.Services.AddMauiBlazorWebView();
			builder.Services.AddSingleton<WeatherForecastService>();

			builder.Services.AddSingleton(SemanticScreenReader.Default);
			builder.Services.AddSingleton<MainViewModel>();
			builder.Services.AddSingleton<MainPage>();

#if DEBUG
			builder.Logging.AddDebug();
			builder.Services.AddBlazorWebViewDeveloperTools();
#endif

			return builder.Build();
		}
	}
}
