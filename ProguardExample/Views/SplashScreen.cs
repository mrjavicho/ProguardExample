﻿using Android.App;
using Android.Content.PM;
using MvvmCross.Droid.Views;

namespace ProguardExample
{
	[Activity(
	  Label = "ProguardExample"
		, MainLauncher = true
		, NoHistory = true
		, ScreenOrientation = ScreenOrientation.Portrait)]
	public class SplashScreen : MvxSplashScreenActivity
	{
		public SplashScreen()
			: base(Resource.Layout.Main)
		{
		}
	}
}