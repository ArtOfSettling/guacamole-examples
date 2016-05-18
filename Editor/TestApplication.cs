using WellFired.Guacamole;

namespace WellFired.Test1.Editor
{
	public class TestApplication
	{
		[UnityEditor.MenuItem ("Window/guacamole/Test 1")]
		static void TestWindow () 
		{
			var application = new WellFired.Guacamole.Unity.Editor.Application();

			var context = new WellFired.Guacamole.Unity.Editor.ApplicationInitializationContext();
			context.MainContent = typeof(TestWindow);
			context.UIRect = new UIRect(50, 50, 600, 200);
			context.MinSize = new UISize(200, 50);
			context.Title = "Test";

			application.Launch(context);
		}
	}
}