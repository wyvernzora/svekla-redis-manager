using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Svekla.Persistence
{
    /// <summary>
    /// Global settings class
    /// Contains global configuration and (if necessary) notifies
    /// program components of any changes.
    /// </summary>
    public class GlobalSettings
    {
        #region Singleton

        private static GlobalSettings _instance = null;

        public static GlobalSettings Instance
        {
            get
            {
                if (_instance == null) _instance = new GlobalSettings(); // default settings
                return _instance;
            }
        }

        public static GlobalSettings DefaultInstance
        { get { return new GlobalSettings(); } }

        public static void LoadSettings(String configXml)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Change Notifications

        public class SettingsChangedEventArgs : EventArgs
        {
            public SettingsChangedEventArgs(String name, Object o, Object n)
            {
                SettingName = name;
                OldValue = o;
                NewValue = n;
            }

            public String SettingName
            { get; set; }

            public Object OldValue
            { get; set; }

            public Object NewValue
            { get; set; }

        }

        private EventHandler<SettingsChangedEventArgs> onChanged;
        public event EventHandler<SettingsChangedEventArgs> SettingsChanged
        { add { onChanged += value; } remove { onChanged -= value; } }

        private void NotifyChange(SettingsChangedEventArgs e)
        {
            EventHandler<SettingsChangedEventArgs> handler = onChanged;
            if (handler != null) handler(null, e);
        }

        #endregion


        private Int32 pingInterval = 1000;
        public Int32 PingInterval
        {
            get { return pingInterval; }
            set
            {
                SettingsChangedEventArgs e = new SettingsChangedEventArgs("PingInterval", pingInterval, value);
                pingInterval = value;
                NotifyChange(e);
            }
        }

        private Int32 pingTimeout = 2000;
        public Int32 PingTimeout
        {
            get { return pingTimeout; }
            set
            {
                SettingsChangedEventArgs e = new SettingsChangedEventArgs("PingTimeout", pingTimeout, value);
                pingTimeout = value;
                NotifyChange(e);
            }
        }
    }
}
