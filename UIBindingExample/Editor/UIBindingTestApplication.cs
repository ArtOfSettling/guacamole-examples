namespace WellFired.Guacamole.Examples.UIBinding
{
	public class UIBindingTestApplication
	{
		[UnityEditor.MenuItem("Window/guacamole/Test/UIBindingTest")]
		static void OpenWindow()
		{
			var application = new Guacamole.Unity.Editor.Application();

			var context = new Guacamole.Unity.Editor.ApplicationInitializationContext
			{
				MainContent = typeof(UIBindingTestWindow),
				UIRect = new UIRect(50, 50, 600, 200),
				MinSize = new UISize(260, 60),
				Title = "UIBindingTest"
			};

			application.Launch(context);
		}
	}
}