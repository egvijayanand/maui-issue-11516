using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace EmbeddedWindows
{
	public partial class MainViewModel : ObservableObject
	{
		private int count;

		[ObservableProperty]
		private string countText = "Click me";

		[RelayCommand]
		private void Count()
		{
			count++;
			CountText = count switch
			{
				1 => $"Clicked {count} time",
				_ => $"Clicked {count} times",
			};
		}
	}
}
