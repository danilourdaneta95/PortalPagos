using Plugin.Settings;
using Plugin.Settings.Abstractions;
using System;

namespace Mobile.App.Helpers
{
    /// <summary>
    /// This is the Settings static class that can be used in your Core solution or in any
    /// of your client applications. All settings are laid out the same exact way with getters
    /// and setters.
    /// </summary>
    public static class Settings
    {
        private static ISettings AppSettings
        {
            get
            {
                return CrossSettings.Current;
            }
        }

        #region Setting Constants

        private const string SettingsKey = "settings_key";
        private static readonly string SettingsDefault = string.Empty;

        #endregion Setting Constants

        public static string GeneralSettings
        {
            get
            {
                return AppSettings.GetValueOrDefault(SettingsKey, SettingsDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue(SettingsKey, value);
            }
        }
        public static string DeviceId { get; internal set; }

        public static string LastVideo
        {
            get
            {
                return AppSettings.GetValueOrDefault("LastVideo", String.Empty);
            }
            set
            {
                AppSettings.AddOrUpdateValue("LastVideo", value);
            }
        }

        public static string LastVideoPath
        {
            get
            {
                return AppSettings.GetValueOrDefault("LastVideoPath", String.Empty);
            }
            set
            {
                AppSettings.AddOrUpdateValue("LastVideoPath", value);
            }
        }

        public static string LastVideoName
        {
            get
            {
                return AppSettings.GetValueOrDefault("LastVideoName", String.Empty);
            }
            set
            {
                AppSettings.AddOrUpdateValue("LastVideoName", value);
            }
        }


        public static string SubsidiaryCode
        {
            get
            {
                return AppSettings.GetValueOrDefault("SubsidiaryCode", String.Empty);
            }
            set
            {
                AppSettings.AddOrUpdateValue("SubsidiaryCode", value);
            }
        }
    }
}