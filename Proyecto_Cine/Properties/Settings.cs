using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Cine.Properties
{
    internal sealed partial class Settings :
       global::System.Configuration.ApplicationSettingsBase
    {
        private static Settings defaultInstance =
            (Settings)global::System.Configuration.ApplicationSettingsBase
                .Synchronized(new Settings());

        public static Settings Default => defaultInstance;

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool RecordarSesion
        {
            get => (bool)this["RecordarSesion"];
            set => this["RecordarSesion"] = value;
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string EmailGuardado
        {
            get => (string)this["EmailGuardado"];
            set => this["EmailGuardado"] = value;
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string PasswordGuardado
        {
            get => (string)this["PasswordGuardado"];
            set => this["PasswordGuardado"] = value;
        }
    }
}