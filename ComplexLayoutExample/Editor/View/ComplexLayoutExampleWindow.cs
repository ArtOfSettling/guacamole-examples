namespace WellFired.Guacamole.Examples.ComplexLayoutExample
{
	public class ComplexLayoutExampleWindow : Window
	{
		public static readonly UIColor _backgroundColor = UIColor.FromRGB(70, 70, 70);
		public static readonly UIColor _darkerBackgroundColor = UIColor.FromRGB(50, 50, 50);
		public static readonly UIColor _buttonBorder = UIColor.FromRGB(88, 88, 88);

		public ComplexLayoutExampleWindow()
		{
			BackgroundColor = _backgroundColor;
			Padding = new UIPadding(5, 5, 5, 5);

			var header = new AdjacentLayout {
				BackgroundColor = UIColor.Clear,
				Spacing = 5,
				Orientation = OrientationOptions.Horizontal,
				Children = {
					new AdjacentLayout {
						BackgroundColor = _darkerBackgroundColor,
						Orientation = OrientationOptions.Horizontal,
						Spacing = 5,
						Padding = 6,
						CornerRadius = 8.0,
						Children = {
							new AdjacentLayout {
								BackgroundColor = _buttonBorder,
								Orientation = OrientationOptions.Horizontal,
								Padding = 2,
								Spacing = 3,
								CornerRadius = 8.0,
								Children = {
									new Button {
										CornerRadius = 8.0,
										CornerMask = CornerMask.Left,
										Text = "New"
									},
									new Button {
										CornerRadius = 8.0,
										CornerMask = CornerMask.Right,
										Text = "Open"
									}
								}
							}
						}
					},
					new AdjacentLayout {
						BackgroundColor = _darkerBackgroundColor,
						Orientation = OrientationOptions.Horizontal,
						Spacing = 5,
						Padding = 6,
						CornerRadius = 8.0,
						Children = {
							new AdjacentLayout {
								BackgroundColor = _buttonBorder,
								Orientation = OrientationOptions.Horizontal,
								Padding = 2,
								Spacing = 3,
								CornerRadius = 8.0,
								Children = {
									new Label {
										Text = "Name",
										CornerRadius = 8.0,
										CornerMask = CornerMask.Left
									},
									new TextEntry {
										Text = "Sequence",
										CornerRadius = 8.0,
										CornerMask = CornerMask.Right
									}
								}
							},
							new AdjacentLayout {
								BackgroundColor = _buttonBorder,
								Orientation = OrientationOptions.Horizontal,
								Padding = 2,
								Spacing = 3,
								CornerRadius = 8.0,
								Children = {
									new Label {
										Text = "Duration",
										CornerRadius = 8.0,
										CornerMask = CornerMask.Left
									},
									new NumberEntry {
										Number = 10,
										CornerRadius = 8.0,
										CornerMask = CornerMask.Right
									}
								}
							},
							new AdjacentLayout {
								BackgroundColor = _buttonBorder,
								Orientation = OrientationOptions.Horizontal,
								Padding = 2,
								Spacing = 3,
								CornerRadius = 8.0,
								Children = {
									new Button {
										CornerRadius = 8.0,
										CornerMask = CornerMask.Left,
										Text = "Duplicate"
									},
									new Button {
										CornerRadius = 8.0,
										CornerMask = CornerMask.Right,
										Text = "Prefab"
									}
								}
							}
						}
					}
				}
			};

			Content = header;
			/*
			Content = new AdjacentLayout {
				Orientation = OrientationOptions.Vertical,
				HorizontalLayout = LayoutOptions.Fill,
				VerticalLayout = LayoutOptions.Fill,
				BackgroundColor = UIColor.Beige,
				Padding = 5,
				Spacing = 5,
				Children = {
					header,
					new AdjacentLayout {
						Orientation = OrientationOptions.Vertical,
						HorizontalLayout = LayoutOptions.Fill,
						VerticalLayout = LayoutOptions.Fill,
						Spacing = 5,
						Padding = 5,
						BackgroundColor = UIColor.Black,
						Children = {
							new AdjacentLayout {
								Orientation = OrientationOptions.Horizontal,
								Spacing = 5,
								Padding = 5,
								BackgroundColor = UIColor.VioletRed,
							},
							new AdjacentLayout {
								Orientation = OrientationOptions.Horizontal,
								Spacing = 5,
								Padding = 5,
								BackgroundColor = UIColor.Turquoise,
							},
							new AdjacentLayout {
								Orientation = OrientationOptions.Horizontal,
								VerticalLayout = LayoutOptions.Fill,
								Spacing = 5,
								Padding = 5,
								BackgroundColor = UIColor.MediumBlue,
							},
							new AdjacentLayout {
								Orientation = OrientationOptions.Horizontal,
								Spacing = 5,
								Padding = 5,
								BackgroundColor = UIColor.DarkOliveGreen,
							},
						},
					},
				}
			};

			/*
			const string assetPath = "Assets/guacamole-examples/ComplexLayoutExample/Editor/WindowData.asset";
			var windowData = AssetDatabase.LoadAssetAtPath<ComplexLayoutExampleModel>(assetPath);
			if(windowData == null) {
				windowData = ScriptableObject.CreateInstance<ComplexLayoutExampleModel>();
				AssetDatabase.CreateAsset(windowData, assetPath);
			}

			BindingContext = new ComplexLayoutExampleViewModel { Model = windowData };

			durationEntry.Bind(NumberEntry.NumberProperty, "CurrentSequenceDuration");
			nameEntry.Bind(TextEntry.TextProperty, "CurrentSequenceName");
			*/
		}
	}
}