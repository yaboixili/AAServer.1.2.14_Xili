﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code is generated by the program.
// Executable version: 4.0.30319.42000
//
// Changes to this file may cause incorrect operation and will be lost if
// re-generate code.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ArcheAgeLogin.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.8.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1237")]
        public int ArcheAge_Port {
            get {
                return ((int)(this["ArcheAge_Port"]));
            }
            set {
                this["ArcheAge_Port"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1231")]
        public int Game_Port {
            get {
                return ((int)(this["Game_Port"]));
            }
            set {
                this["Game_Port"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("127.0.0.1")]
        public string DataBase_Host {
            get {
                return ((string)(this["DataBase_Host"]));
            }
            set {
                this["DataBase_Host"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("3306")]
        public int DataBase_Port {
            get {
                return ((int)(this["DataBase_Port"]));
            }
            set {
                this["DataBase_Port"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("root")]
        public string DataBase_User {
            get {
                return ((string)(this["DataBase_User"]));
            }
            set {
                this["DataBase_User"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("archeage")]
        public string DataBase_Name {
            get {
                return ((string)(this["DataBase_Name"]));
            }
            set {
                this["DataBase_Name"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Account_AutoCreation {
            get {
                return ((bool)(this["Account_AutoCreation"]));
            }
            set {
                this["Account_AutoCreation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("root")]
        public string DataBase_Password {
            get {
                return ((string)(this["DataBase_Password"]));
            }
            set {
                this["DataBase_Password"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("127.0.0.1")]
        public string Main_IP {
            get {
                return ((string)(this["Main_IP"]));
            }
            set {
                this["Main_IP"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public string ServerClientVersion {
            get {
                return ((string)(this["ServerClientVersion"]));
            }
            set {
                this["ServerClientVersion"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool SSL {
            get {
                return ((bool)(this["SSL"]));
            }
            set {
                this["SSL"] = value;
            }
        }
    }
}
