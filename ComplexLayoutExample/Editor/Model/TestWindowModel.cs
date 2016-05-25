using UnityEngine;
using WellFired.Guacamole.Databinding.Unity.Runtime;

namespace WellFired.Test1.Editor
{
	public class TestWindowModel : ObservableScriptableObject 
	{
		[SerializeField]private float _currentSequenceDuration;
		public float CurrentSequenceDuration
		{
			get { return _currentSequenceDuration; }
			set { SetProperty(ref _currentSequenceDuration, value, "CurrentSequenceDuration"); }
		}
		
		[SerializeField]private string _currentSequenceName;
		public string CurrentSequenceName
		{
			get { return _currentSequenceName; }
			set { SetProperty(ref _currentSequenceName, value, "CurrentSequenceName"); }
		}
	}
}