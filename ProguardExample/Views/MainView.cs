using Android.App;
using Android.Widget;
using Android.OS;
using MvvmCross.Droid.Views;
using ExampleCore;

namespace ProguardExample
{
	[Activity(Label = "Proguard Example", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : MvxActivity<MainViewModel>
	{
		int count = 1;

		TextView tvMessage;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			tvMessage = FindViewById<TextView>(Resource.Id.tvMessage);
			tvMessage.Text = ViewModel.GetMessage();

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button>(Resource.Id.myButton);

			button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };
		}
	}
}

