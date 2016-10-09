using System;
using MvvmCross.Core.ViewModels;

namespace ExampleCore
{
	public class MainViewModel : MvxViewModel
	{
		public MainViewModel()
		{
			Message = GetMessage();
		}

		public string Message { get; set; }

		public string GetMessage() 
		{
			return "This is the result of calling a method, the inner logic of this method should be obfuscated";
		}

		public string GetSecretCode() 
		{
			return "123456";
		}

		public const string SecureServerUrl = "https://es.mrjavicho.superapi";
	}
}
