using Android.App;
using Android.OS;
using Android.Widget;

namespace com.xamarin.example.tabhostwalkthrough
{
	[Activity]
	public class SessionsActivity : Activity
	{
		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);
			TextView textview = new TextView (this);
			textview.Text = "This is the SDessions tab";
			SetContentView (textview);
		}
	}
}

