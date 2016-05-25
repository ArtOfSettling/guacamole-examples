using UnityEditor;
using UnityEngine;

namespace WellFired.Guacamole.Examples.UIBinding
{
	public class UIBindingTestWindow : Window
	{
		public UIBindingTestWindow()
		{
			Padding = new UIPadding(5);
			
			var destinationElement = new TextEntry
			{
				BackgroundColor = UIColor.White
			};

			var sourceElement = new Slider
			{
				BackgroundColor = UIColor.White
			};

			Content = new AdjacentLayout
			{
				Children =
				{
					destinationElement,
					sourceElement
				}
			};

			destinationElement.BindingContext = sourceElement;

			destinationElement.Bind(TextEntry.TextProperty, "Value");
		}
	}
}