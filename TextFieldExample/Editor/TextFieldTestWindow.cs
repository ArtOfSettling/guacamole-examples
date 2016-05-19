using WellFired.Guacamole;

namespace WellFired.TextFieldTest.Editor
{
	public class TextFieldTestWindow : Window
	{
		public TextFieldTestWindow()
		{
			Padding = new UIPadding(5);
			
			var textEntryLeft = new TextEntry
			{
				BackgroundColor = UIColor.White,
				Text = "LeftAlign"
			};

			var textEntryCenter = new TextEntry
			{
				HorizontalTextAlign = UITextAlign.Midle,
				BackgroundColor = UIColor.White,
				Text = "CenterAlign"
			};

			var textEntryRight = new TextEntry
			{
				HorizontalTextAlign = UITextAlign.End,
				BackgroundColor = UIColor.White,
				Text = "RightAlign"
			};

			Content = new AdjacentLayout
			{
				Spacing = 5,
				Children =
				{
					textEntryLeft,
					textEntryCenter,
					textEntryRight
				}
			};
		}
	}
}