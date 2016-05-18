using WellFired.Guacamole.Databinding.Unity.Editor;
using System;
using UnityEngine;

namespace WellFired.Test1.Editor
{
	public class TestWindowModel : ObservableScriptableObject 
	{
		//[HideInInspector]
		[SerializeField]private float currentSequenceDuration;
		public float CurrentSequenceDuration
		{
			get { return currentSequenceDuration; }
			set { SetProperty<float>(ref currentSequenceDuration, value, "CurrentSequenceDuration"); }
		}

		//[HideInInspector]
		[SerializeField]private string currentSequenceName;
		public string CurrentSequenceName
		{
			get { return currentSequenceName; }
			set { SetProperty<string>(ref currentSequenceName, value, "CurrentSequenceName"); }
		}
	}
}