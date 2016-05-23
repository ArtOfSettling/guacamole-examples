using UnityEngine;
using WellFired.Guacamole.Databinding.Unity.Editor;

namespace WellFired.Guacamole.Examples.TwoWayBinding
{
	public class TwoWayBindingTestModel : ObservableScriptableObject
	{
		[HideInInspector] [SerializeField] private string _boundText = "Initial Text";
		public string BoundText
		{
			get { return _boundText; }
			set { SetProperty(ref _boundText, value, "BoundText"); }
		}
	}
}