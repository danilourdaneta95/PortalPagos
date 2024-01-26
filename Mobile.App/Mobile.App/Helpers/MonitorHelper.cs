
using System;
using System.Collections.Generic;
using System.Text;

namespace Mobile.App.Helpers
{
    public class MonitorHelper
    {
        public static void TrackError(string Page, string Sku, string ErrorCode, string ErrorMessage)
        {
           /*Analytics.TrackEvent("LogError", new Dictionary<string, string> {
                        { "MacAddress", GlobalSetting.Instance.MacAddress },
                        { "Page", Page },
                        { "SessionId", GlobalSetting.Instance.SessionId },
                        { "Sku", Sku} ,
                        { "ErrorCode", ErrorCode} ,
                        { "ErrorMessage", ErrorMessage} ,
                        { "SubsidiaryCode", ""} ,
                        { "SubsidiaryName", ""} ,
                        });*/
        }
    }
}