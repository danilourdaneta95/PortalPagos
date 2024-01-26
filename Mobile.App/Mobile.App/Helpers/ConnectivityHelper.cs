using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.Connectivity;

namespace Mobile.App.Helpers
{
    public static class ConnectivityHelper
    {
        private static DateTime _lastCheckDateConnectivity;
        private static bool _lastCheckResponseConnectivity;

        static ConnectivityHelper()
        {
            _lastCheckDateConnectivity = DateTime.MinValue;
            _lastCheckResponseConnectivity = false;
        }


        public static async Task<bool> CheckConnectivityAsync()
        {
            bool response;

            if (CrossConnectivity.Current.IsConnected)
            {
                if (_lastCheckDateConnectivity.AddSeconds(3) < DateTime.Now)
                {
                    _lastCheckDateConnectivity = DateTime.Now;

                    response = true;
                }
                else
                {
                    response = _lastCheckResponseConnectivity;
                }
            }
            else
            {
                //GlobalSetting.Instance.IsHostReachable = false;
                response = false;
            }

            _lastCheckResponseConnectivity = response;

            return response;
        }
    }

}
