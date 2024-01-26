using System;
using Xamarin.Forms;

namespace Mobile.App
{
    public class GlobalSetting : BindableObject
    {
        public GlobalSetting()
        {
            Init();
        }

        public readonly bool? IndProduccion = false;

        public bool Init()
        {
            this.VERSION_APP = "v2.5.3:";
            this.Ambiente = "";
            if ((bool)IndProduccion)
            {
                this.DefaultEndpoint = "https://0wg64hrzqd.execute-api.ca-central-1.amazonaws.com/prd/api/";
                this.IdentityEndpoint = "https://0wg64hrzqd.execute-api.ca-central-1.amazonaws.com/prd/api/";
                this.Api_Key = "M4k9wUWBCe6tNyHmc9Fuca6toPzD8BSn3IFJNpql";
                this.Ambiente = "PRD";
                this.VERSION_APP += Ambiente;
            }
            else if (!(bool)IndProduccion)
            {
                this.DefaultEndpoint = "https://ux9wpccub6.execute-api.us-east-1.amazonaws.com/qa/api/";
                this.IdentityEndpoint = "https://ux9wpccub6.execute-api.us-east-1.amazonaws.com/qa/api/";
                this.Api_Key = "e3Z23YLIid93Z7K8bXXGY2MLrAPLHo3w8B9N3MXp";
                this.Ambiente = "QA";
                this.VERSION_APP += this.Ambiente;
            }
            else
            {
                this.DefaultEndpoint = "https://ux9wpccub6.execute-api.us-east-1.amazonaws.com/qa/api/";
                this.IdentityEndpoint = "https://ux9wpccub6.execute-api.us-east-1.amazonaws.com/qa/api/";
                this.Api_Key = "e3Z23YLIid93Z7K8bXXGY2MLrAPLHo3w8B9N3MXp";
                this.Ambiente = "DEV";
                this.VERSION_APP += this.Ambiente;
            }

            this.BaseEndpoint = DefaultEndpoint;
            this.ClientId = "appprices";
            this.ClientSecret = "apiPriceRipley123";
            this.UserAgent = "SelfCheckout";

            return true;
        }
        public string IdentityEndpoint { get; internal set; }

        public string DefaultEndpoint { get; set; }

        public string Api_Key { get; set; }

        public int InactivityTimeOut { get; set; } = 0;

        public int InactivityTimeOutModal { get; set; } = 0;

        public int InactivityTime { get; set; }
        public int BreakTime { get; set; }
        public DateTime LastActivity { get; set; } = DateTime.Now;

        public string SessionId { get; set; } = Guid.NewGuid().ToString();
        public int ServiceTimeout { get; set; }
        public static GlobalSetting Instance { get; } = new GlobalSetting();

        public string BaseEndpoint
        {
            get { return _baseEndpoint; }
            set
            {
                _baseEndpoint = value;
                UpdateEndpoint(_baseEndpoint);
            }
        }

        public string ClientId { get; private set; }
        public string ClientSecret { get; private set; }
        public string ServiceEndpoint { get; set; }

        private bool _isHostReachable = true;
        private string _baseEndpoint;

        public int DeviceId { get; internal set; }

        public bool IsHostReachable
        {
            get { return _isHostReachable; }
            set
            {
                _isHostReachable = value;
                OnPropertyChanged("IsHostReachable");
            }
        }

        private void UpdateEndpoint(string baseEndpoint)
        {
            ServiceEndpoint = string.Format("{0}", baseEndpoint);
        }

        public string Ambiente { get; set; }
        public string ServiceCode { get; set; }
        public string EmployeeName { get; internal set; }
        public string XmlPublic { get; set; } = @"<RSAKeyValue><Modulus>1jqrAoUiNlJ86SB1vL+vVT+yQdo2c2LGB0uFPM2+NfvjMyIAOZnNX7YjVC8M8cXSz13hWKPbGbEPJkRUB/6U6wJPvkJZr4g3Cqjg3IOLsXLLtAVGGgnWuT3IKReanv/PYS0Oxs45q+L+EUuxUMTjT4oeqDPbuTnXXrbw0mGkwCwyUgK6KtwIwED4rekM7h+P6pH9iCwmtcTvc8AxJ8L5FaW19aD5z7DbrYeFJ+6mSlKRFCYHIpI70VmO8QTbXIvwO/PQq9tz2SjOD9gGvtmXbJTEc9HQ+ZTKTJDCAEiRDytzQnAoiKEqNk1N/wiN6dGglwt1gNFpGcXK2R8nI1dTcQ==</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";
        public string UserId { get; internal set; }
        public bool PermissionStorageGranted { get; set; }
        public string AccessToken { get; internal set; }
        public DateTime TokenExpires { get; set; }
        public string MacAddress { get; internal set; }
        public string UserAgent { get; internal set; }


        public bool ClientPdp { get; set; }
        public string ClientDni { get; set; }
        public string ClientName { get; set; }
        public string ClientLastName { get; set; }
        public string ClientMail { get; set; }
        public string ClientPhone { get; set; }
        public string ClientMailSaved { get; set; }
        public string ClientPhoneSaved { get; set; }
        public string CodVendedor { get; internal set; }
        public string Tienda { get; internal set; }
        public bool EntryFocused { get; internal set; }
        public string EmployeeCode { get; internal set; }
        public string NumCaja { get; internal set; }
        public bool ClientTerms { get; internal set; }
        public string InactivityText { get; internal set; }
        public string VERSION_APP { get; set; }
        public string CardNumber { get; set; }
        public string ExpYear { get; set; }
        public string ExpMonth { get; set; }
        public string CardCvv { get; set; }
        public int NumCuotas { get; set; }
        public string LogSession { get; set; }

        private Uri ServiceUri(string service, string method)
        {
            UriBuilder builder = new UriBuilder(IdentityEndpoint);
            builder.Path += service + "/" + method;
            return builder.Uri;
        }

        public Uri TransactionsUri(string method)
        {
            return ServiceUri("transactions", method);
        }
    }
}