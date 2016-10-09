using Foundation;
using MvvmCross.Core.ViewModels;

namespace ExampleCore.ViewModels
{
	[Preserve(AllMembers = true)]
	public class MainViewModel : MvxViewModel
	{
		public MainViewModel()
		{
			Message = GetMessage();
		}

		/// <summary>
		/// Esta propiedad, que se utiliza bindeando directamente desde la vista, no se puede recuperar y genera un error:
		/// 
		/// </summary>
		/// <value>The message.</value>
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
