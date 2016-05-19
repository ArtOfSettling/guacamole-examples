using WellFired.Guacamole;

namespace WellFired.TextFieldTest.Editor
{
	public class TextFieldTestWindow : Window
	{
		public TextFieldTestWindow()
		{
			BackgroundColor = UIColor.Grey;
			Padding = new UIPadding(5);
			
			var textEntry = new TextEntry
			{
				HorizontalLayout = LayoutOptions.Expand,
				BackgroundColor = UIColor.White,
				Text = "Text",
				Label = "Example"
			};

			Content = textEntry;
		}
	}
}