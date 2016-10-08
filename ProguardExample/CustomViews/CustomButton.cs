using System;
using Android.Content;
using Android.Runtime;
using Android.Util;
using Android.Widget;

namespace ProguardExample
{
	public class CustomButton : Button
	{
		protected CustomButton(IntPtr javaReference, JniHandleOwnership transfer) :base(javaReference, transfer)
		{
		}

		public CustomButton(Context context) : base (context){ }

		public CustomButton(Context context, IAttributeSet attrs) : base (context, attrs) { }

		public CustomButton(Context context, IAttributeSet attrs, int defStyleAttr) : base (context, attrs, defStyleAttr) { }

		public CustomButton(Context context, IAttributeSet attrs, int defStyleAttr, int defStyleRes) : base (context, attrs, defStyleAttr, defStyleRes){ }
	}
}
