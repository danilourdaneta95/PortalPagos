using Mobile.App.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mobile.App.ViewModels.User
{
    public class LoginViewModel : ViewModelBase
    {
        public LoginViewModel() { }
        public override async Task InitializeAsync(object navigationData)
        {
            await base.InitializeAsync(navigationData);
        }
    }
}
