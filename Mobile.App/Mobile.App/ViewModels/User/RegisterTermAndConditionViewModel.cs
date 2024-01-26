using Mobile.App.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mobile.App.ViewModels.User
{
    public class RegisterTermAndConditionViewModel : ViewModelBase
    {
        public RegisterTermAndConditionViewModel()
        {

        }

        public override async Task InitializeAsync(object navigationData)
        {
            PathFile = "https://drive.google.com/file/d/1WBoDxqTIik3g5FzsK86U0go46HYRzd2I/view?usp=sharing";
            await base.InitializeAsync(navigationData);

        }
        private string _base64String;
        public string Base64String
        {
            get { return _base64String; }
            set
            {
                _base64String = value;
                RaisePropertyChanged(() => Base64String);
            }
        }
        private string _PathFile;
        public string PathFile
        {
            get { return _PathFile; }
            set
            {
                _PathFile = value;
                RaisePropertyChanged(() => PathFile);
            }
        }

    }
}
