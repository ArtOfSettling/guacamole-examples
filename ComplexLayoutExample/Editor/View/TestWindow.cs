﻿using UnityEditor;
using UnityEngine;
using WellFired.Guacamole;

namespace WellFired.Test1.Editor
{
	public class TestWindow : Window
	{
		public TestWindow()
		{
			BackgroundColor = UIColor.Black;

			var durationEntry = new NumberEntry {
				Number = 0,
				Label = "Duration",
			};

			var nameEntry = new TextEntry { 
				BackgroundColor = UIColor.Burlywood,
				TextColor = UIColor.Beige,
				LabelColor = UIColor.Beige,
				Text = "A Sequence",
			};

			Content = new AdjacentLayout {
				Orientation = OrientationOptions.Vertical,
				HorizontalLayout = LayoutOptions.Fill,
				VerticalLayout = LayoutOptions.Fill,
				BackgroundColor = UIColor.Beige,
				Padding = 5,
				Spacing = 5,
				Children = {
					new AdjacentLayout {
						BackgroundColor = UIColor.Chocolate,
						Orientation = OrientationOptions.Horizontal,
						Spacing = 5,
						Padding = 5,
						Children = {
							new AdjacentLayout {
								BackgroundColor = UIColor.Tomato,
								Orientation = OrientationOptions.Horizontal,
								Spacing = 5,
								Padding = 5,
								Children = {
									new Button { 
										BackgroundColor = UIColor.Burlywood,
										Text = "A",
									},
									new Button { 
										BackgroundColor = UIColor.Burlywood,
										Text = "B",
									},
								},
							},
							new AdjacentLayout {
								BackgroundColor = UIColor.Tomato,
								Orientation = OrientationOptions.Horizontal,
								Spacing = 5,
								Padding = 5,
								Children = {
									nameEntry,
									durationEntry,
									new Button  { 
										BackgroundColor = UIColor.Burlywood,
										Text = "E",
									},
									new Button  { 
										BackgroundColor = UIColor.Burlywood,
										Text = "F",
									},
								},
							},
						},
					},
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

			const string assetPath = "Assets/guacamole-examples/Editor/WindowData.asset";
			var windowData = AssetDatabase.LoadAssetAtPath<TestWindowModel>(assetPath);
			if(windowData == null) {
				windowData = ScriptableObject.CreateInstance<TestWindowModel>();
				AssetDatabase.CreateAsset(windowData, assetPath);
			}

			BindingContext = new TestWindowViewModel { Model = windowData };

			durationEntry.Bind(NumberEntry.NumberProperty, "CurrentSequenceDuration");
			nameEntry.Bind(TextEntry.TextProperty, "CurrentSequenceName");
		}
	}
}