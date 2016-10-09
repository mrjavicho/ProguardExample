using System;
using ExampleCore.ViewModels;
using MvvmCross.Core.ViewModels;

namespace ExampleCore
{
	public class App : MvxApplication
	{
		public override void Initialize()
		{
			base.Initialize();
			RegisterAppStart<MainViewModel>();
		}
	}
}
