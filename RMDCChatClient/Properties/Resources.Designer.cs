﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RMDCChatClient.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("RMDCChatClient.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error.
        /// </summary>
        internal static string error {
            get {
                return ResourceManager.GetString("error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please Enter the User name and Password.
        /// </summary>
        internal static string login_emty_credentials {
            get {
                return ResourceManager.GetString("login_emty_credentials", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Wrong User Name or Password.
        /// </summary>
        internal static string login_wrong_credentials {
            get {
                return ResourceManager.GetString("login_wrong_credentials", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Length of the Password should be minimum 8 characters.
        /// </summary>
        internal static string pwd_length_error {
            get {
                return ResourceManager.GetString("pwd_length_error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 2 passwords doesnt match.
        /// </summary>
        internal static string pwd_not_match {
            get {
                return ResourceManager.GetString("pwd_not_match", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Registration Failed try entering different user name.
        /// </summary>
        internal static string reg_failed {
            get {
                return ResourceManager.GetString("reg_failed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Registration Success.
        /// </summary>
        internal static string reg_success {
            get {
                return ResourceManager.GetString("reg_success", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please fill empty fields.
        /// </summary>
        internal static string registration_empty {
            get {
                return ResourceManager.GetString("registration_empty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to send_no_user_selected.
        /// </summary>
        internal static string send_no_user_selected {
            get {
                return ResourceManager.GetString("send_no_user_selected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Success.
        /// </summary>
        internal static string success {
            get {
                return ResourceManager.GetString("success", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to  went offline.
        /// </summary>
        internal static string user_logoff {
            get {
                return ResourceManager.GetString("user_logoff", resourceCulture);
            }
        }
    }
}
