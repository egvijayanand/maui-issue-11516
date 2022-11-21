using Microsoft.UI.Dispatching;
using Microsoft.UI.Xaml;
using System;
using System.Runtime.InteropServices;
using System.Threading;
using WinRT;

namespace EmbeddedWindows
{
	/// <summary>
	/// Program class
	/// </summary>
	static class Program
	{
		[DllImport("Microsoft.ui.xaml.dll")]
		private static extern void XamlCheckProcessRequirements();

		[STAThread]
		static void Main(string[] args)
		{
			XamlCheckProcessRequirements();

			ComWrappersSupport.InitializeComWrappers();
			Application.Start((p) =>
			{
				SynchronizationContext.SetSynchronizationContext(new DispatcherQueueSynchronizationContext(DispatcherQueue.GetForCurrentThread()));
				_ = new App();
			});
		}
	}
}
