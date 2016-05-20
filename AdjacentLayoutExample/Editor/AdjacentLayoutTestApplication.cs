using WellFired.Guacamole;

namespace WellFired.Guacamole.Examples.AdjacentLayoutTest
{
	public class AdjacentLayoutTestApplication
	{
		[UnityEditor.MenuItem("Window/guacamole/Test/AdjacentLayoutTest")]
		static void OpenWindow()
		{
			var application = new Guacamole.Unity.Editor.Application();

			var context = new Guacamole.Unity.Editor.ApplicationInitializationContext
			{
				MainContent = typeof(AdjacentLayoutTestWindow),
				UIRect = new UIRect(50, 50, 600, 200),
				MinSize = new UISize(260, 230),
				Title = "AdjacentLayoutTest"
			};

			application.Launch(context);
		}
	}
}