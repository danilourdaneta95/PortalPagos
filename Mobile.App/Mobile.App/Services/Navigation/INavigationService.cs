using Mobile.App.ViewModels.Base;
using System.Threading.Tasks;

namespace Mobile.App.Services
{
    public interface INavigationService
    {
        string BarBackgroundColorValue { get; set; }
        ViewModelBase PreviousPageViewModel { get; }

        Task InitializeAsync();

        Task NavigateToAsync<TViewModel>() where TViewModel : ViewModelBase;

        Task NavigateToAsync<TViewModel>(object parameter) where TViewModel : ViewModelBase;

        Task RemoveLastFromBackStackAsync();

        Task RemoveBackStackAsync();
        Task NavigateBackAsync();
    }
}