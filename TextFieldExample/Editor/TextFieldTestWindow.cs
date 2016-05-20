using WellFired.Guacamole;

namespace WellFired.TextFieldTest.Editor
{
	public class TextFieldTestWindow : Window
	{
		public TextFieldTestWindow()
		{
			Padding = new UIPadding(5);
			
			var textEntryStartStart = new TextEntry
			{
				BackgroundColor = UIColor.White,
				Text = "Test"
			};

			Content = textEntryStartStart;
		}
	}
}