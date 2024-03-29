﻿using Microsoft.UI.Xaml;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace EmbeddedWindows.WinUI
{
	/// <summary>
	/// Provides application-specific behavior to supplement the default Application class.
	/// </summary>
	public partial class App : MauiWinUIApplication
	{
		/// <summary>
		/// Initializes the singleton application object.  This is the first line of authored code
		/// executed, and as such is the logical equivalent of main() or WinMain().
		/// </summary>
		public App()
		{
			this.InitializeComponent();
		}

		protected override void OnLaunched(LaunchActivatedEventArgs args)
		{
			// Ideally it should call the base version of OnLaunched to set the Services and other properties
			// But for now it results in the "Either set MainPage or override CreateWindow." error
			// Hence conditionally suppress this message while using UseMauiEmbedding() call on the builder object
			//base.OnLaunched(args);
			var mauiApp = CreateMauiApp();
			var mauiContext = new MauiContext(mauiApp.Services);
			Services = mauiContext.Services;
			new MainWindow().Activate();
		}

		protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
	}
}
