using WellFired.Guacamole;

namespace WellFired.TextFieldTest.Editor
{
	public class TextFieldAlignTestApplication
	{
		[UnityEditor.MenuItem("Window/guacamole/Test/TextFieldAlign")]
		static void OpenWindow()
		{
			var application = new Guacamole.Unity.Editor.Application();

			var context = new Guacamole.Unity.Editor.ApplicationInitializationContext
			{
				MainContent = typeof(TextFieldAlignTestWindow),
				UIRect = new UIRect(50, 50, 600, 200),
				MinSize = new UISize(260, 230),
				Title = "TestFieldAlignTest"
			};

			application.Launch(context);
		}
	}
}