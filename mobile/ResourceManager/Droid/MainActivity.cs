using Android.App;
using Android.OS;
using Android.Widget;
using ResourceManager.Core.ViewModels;
using ResourceManager.Droid.Views.Base;

namespace ResourceManager.Droid
{
    [Activity(Label = "Resource Manager", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : BaseActivity<MainViewModel>
    {
        public MainActivity() : base(new MainViewModel()) { }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.myButton);
            button.Text = ViewModel.ButtonText;

            button.Click +=  delegate { button.Text = ViewModel.Clicks; };
        }
    }
}

