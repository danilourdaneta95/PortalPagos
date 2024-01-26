using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using System;
using System.Timers;
using System.Globalization;
using System.Diagnostics;
using Mobile.App.ViewModels.User;
using Mobile.App.Services;

namespace Mobile.App.ViewModels.Base
{
    public abstract class ViewModelBase : ExtendedBindableObject
    {
        #region Protected Fields

        protected readonly INavigationService NavigationService;

        private bool _isModalAlert = false;

        #endregion Protected Fields

        #region Private Fields

        private bool _isBusy;
        private bool _isConnected;

        #endregion Private Fields

        #region Public Constructors

        protected ViewModelBase()
        {
            NavigationService = ViewModelLocator.Resolve<INavigationService>();
            IsConnected = true;
            _isConnected = true;
        }

        public ICommand OpenModalCommand => new Command(async () => await OpenModal());
        public ICommand CloseModalCommand => new Command(async () => await CloseModal());

        #endregion Public Constructors

        #region Public Properties

        public bool IsBusy
        {
            get
            {
                return _isBusy;
            }

            set
            {
                _isBusy = value;
                RaisePropertyChanged(() => IsBusy);
                RaisePropertyChanged(() => ShowLoader);
            }
        }

        private string _BtnSalir;
        public string BtnSalir
        {
            get { return _BtnSalir; }
            set
            {
                _BtnSalir = value;
                RaisePropertyChanged(() => BtnSalir);
            }
        }

        private string _BtnRegresar;
        public string BtnRegresar
        {
            get { return _BtnRegresar; }
            set
            {
                _BtnRegresar = value;
                RaisePropertyChanged(() => BtnRegresar);
            }
        }

        public bool ShowLoader => (IsBusy || IsScanning);

        private bool _IsScanning;
        public bool IsScanning
        {
            get { return _IsScanning; }

            set
            {
                _IsScanning = value;
                RaisePropertyChanged(() => IsScanning);
                RaisePropertyChanged(() => ShowLoader);
            }
        }

        public bool IsConnected
        {
            get { return _isConnected; }
            set
            {
                _isConnected = value;
                RaisePropertyChanged(() => IsConnected);
            }
        }

        public ICommand BackCommand => new Command(async () => await Back());
        protected virtual async Task Back()
        {
            if (IsBusy)
            {
                return;
            }
            try
            {
                IsBusy = true;
                await NavigationService.NavigateBackAsync();
            }
            catch (Exception)
            {
                //Do nothing
            }
            finally
            {
                IsBusy = false;
            }
        }

        public ICommand CloseCommand => new Command(async () => await Close());
        protected virtual async Task Close()
        {
            if (IsBusy)
            {
                return;
            }
            try
            {
                IsBusy = true;
                //await NavigationService.PopToRoot<LoginViewModel>();
            }
            catch (Exception)
            {
                //Do nothing
            }
            finally
            {
                IsBusy = false;
            }
        }
        #endregion Public Properties

        #region Public Methods

        private string _messageError;

        public string MessageError
        {
            get { return _messageError; }
            set
            {
                _messageError = value;
                RaisePropertyChanged(() => MessageError);
            }
        }

        public virtual async Task InitializeAsync(object navigationData)
        {
            IsConnected = true;
        }
        public bool IsModalAlert
        {
            get { return _isModalAlert; }
            set
            {
                _isModalAlert = value;
                RaisePropertyChanged(() => IsModalAlert);
            }
        }

        public bool IsModalAlertInactivity
        {
            get { return _isModalAlertInactivity; }
            set
            {
                _isModalAlertInactivity = value;
                RaisePropertyChanged(() => IsModalAlertInactivity);
            }
        }

        private Timer AlertTimer;
        private bool _isModalAlertInactivity;

        public void StartAlertTimer(string message)
        {
            try
            {
                MessageError = message;
                IsModalAlert = true;
                AlertTimer = null;
                AlertTimer = new Timer(3000);
                AlertTimer.Elapsed += new ElapsedEventHandler(AlertTimerElapsed);
                AlertTimer.Enabled = true;
                AlertTimer.AutoReset = false;
                AlertTimer.Start();
            }
            catch (Exception)
            {
            }
        }

        private void AlertTimerElapsed(object sender, ElapsedEventArgs e)
        {
            DisposeAlertTimer();
        }

        protected void DisposeAlertTimer()
        {
            try
            {
                IsModalAlert = false;
                if (AlertTimer != null)
                {
                    AlertTimer.Enabled = false;
                    AlertTimer.Stop();
                    AlertTimer.Dispose();
                    AlertTimer = null;
                }
            }
            catch (Exception ex)
            {
                //Do nothing
            }
        }

        private int _count;

        public int Counter
        {
            get { return _count; }
            set
            {
                _count = value;
                RaisePropertyChanged(() => Counter);
            }
        }

        public virtual void ShowAlertInactivity()
        {
            IsModalAlertInactivity = true;
        }

        public virtual void HideAlertInactivity()
        {
            IsModalAlertInactivity = false;
        }

        #endregion Public Methods

        #region Private Methods

        
        private async Task OpenModal()
        {
            IsModalAlert = true;
        }

        protected virtual async Task CloseModal()
        {
            IsModalAlert = false;
        }
        
        public String getFormatValue(String value)
        {
            NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
            double totalValue = (Convert.ToDouble(value) / 100);
            String finalValue = totalValue.ToString("N", nfi);
            return finalValue;
        }
        #endregion Private Methods

    }
}