using Mobile.App.Models.Common;
using Mobile.App.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Mobile.App.Controls
{
    public class CustomNavigationPage : NavigationPage
    {
        public CustomNavigationPage() : base() { }
        public CustomNavigationPage(Page root) : base(root) { }
    }
}
