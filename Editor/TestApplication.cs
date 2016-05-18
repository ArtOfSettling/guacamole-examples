using WellFired.Guacamole;

namespace WellFired.Test1.Editor
{
	public class TestApplication
	{
		[UnityEditor.MenuItem ("Window/guacamole/Test 1")]
		static void TestWindow () 
		{
			var application = new Guacamole.Unity.Editor.Application();

			var context = new Guacamole.Unity.Editor.ApplicationInitializationContext
			{
				MainContent = typeof (TestWindow),
				UIRect = new UIRect(50, 50, 600, 200),
				MinSize = new UISize(200, 50),
				Title = "Test"
			};

			application.Launch(context);
		}
	}
}