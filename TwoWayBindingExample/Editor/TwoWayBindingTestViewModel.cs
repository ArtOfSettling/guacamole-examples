using WellFired.Guacamole.Databinding;

namespace WellFired.Guacamole.Examples.TwoWayBinding
{
	public class TwoWayBindingTestViewModel : ObservableBase
	{
		public TwoWayBindingTestModel Model { get; set; }
		
		public string BoundText
		{
			get { return Model.BoundText; }
			set
			{
				var data = Model.BoundText;
				if (SetProperty(ref data, value, "BoundText"))
					Model.BoundText = data;
			}
		}
	}
}