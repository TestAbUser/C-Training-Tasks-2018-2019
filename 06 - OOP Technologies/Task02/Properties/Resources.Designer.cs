﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Task02.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Task02.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to The inner R cannot be greater than or equal to the outer R!.
        /// </summary>
        internal static string InnerRadiusTooBigWarning {
            get {
                return ResourceManager.GetString("InnerRadiusTooBigWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enter a value for the outer radius:.
        /// </summary>
        internal static string OuterRadiusOption {
            get {
                return ResourceManager.GetString("OuterRadiusOption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The outer R cannot be less than or equal to the inner R!.
        /// </summary>
        internal static string OuterRadiusTooSmallWarning {
            get {
                return ResourceManager.GetString("OuterRadiusTooSmallWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ring has been created. Its properties are:
        ///x = {0}
        ///y = {1}
        ///inner R = {2}
        ///outer R = {3}
        ///inner C = {4}
        ///outer C = {5}
        ///sum of C = {6}
        ///S = {7}
        ///.
        /// </summary>
        internal static string RingParameters {
            get {
                return ResourceManager.GetString("RingParameters", resourceCulture);
            }
        }
    }
}
