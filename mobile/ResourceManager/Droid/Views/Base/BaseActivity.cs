using Android.App;
using Android.OS;
using ResourceManager.Core.ViewModels.Base;

namespace ResourceManager.Droid.Views.Base
{
    public abstract class BaseActivity<TViewModel>  : Activity
    {
        protected TViewModel ViewModel { get; set; }

        public BaseActivity(TViewModel viewModel)
        {
            ViewModel = viewModel;
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Title = (ViewModel as BaseViewModel).PageTitle;
        }
    }
}
