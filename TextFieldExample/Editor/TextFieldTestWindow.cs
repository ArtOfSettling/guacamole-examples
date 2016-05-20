namespace WellFired.Guacamole.Examples.TextField
{
	public class TextFieldTestWindow : Window
	{
		public TextFieldTestWindow()
		{
			Padding = new UIPadding(5);

			Content = new TextEntry
			{
				BackgroundColor = UIColor.White,
				Text = "Test"
			};
		}
	}
}