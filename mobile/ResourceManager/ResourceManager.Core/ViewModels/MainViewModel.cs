using System;
using ResourceManager.Core.Constants;
using ResourceManager.Core.ViewModels.Base;

namespace ResourceManager.Core.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public override string PageTitle => TextConstants.PageTitle_Main;

        public string ButtonText { get; set; } = TextConstants.Button_MainButton;

        private int _count = 0;
        public string Clicks => $"{_count++} Clicks!";
    }
}
