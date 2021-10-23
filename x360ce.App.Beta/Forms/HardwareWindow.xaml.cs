﻿using JocysCom.ClassLibrary.Controls;
using System.Windows;

namespace x360ce.App.Forms
{
	/// <summary>
	/// Interaction logic for HardwareWindow.xaml
	/// </summary>
	public partial class HardwareWindow : Window
	{
		public HardwareWindow()
		{
			InitHelper.InitTimer(this, InitializeComponent);
			HardwareHost.Child = new JocysCom.ClassLibrary.IO.HardwareControl();
		}
	}
}
