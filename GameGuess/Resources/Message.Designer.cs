﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GameGuess.Resources {
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
    internal class Message {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Message() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("GameGuess.Resources.Message", typeof(Message).Assembly);
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
        ///   Looks up a localized string similar to Вы ввели недопустимый символ!.
        /// </summary>
        internal static string DefectString {
            get {
                return ResourceManager.GetString("DefectString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Я загадал число от {0} до {1} включительно. Попробуете угадать?.
        /// </summary>
        internal static string GuessNumber {
            get {
                return ResourceManager.GetString("GuessNumber", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Введите число от {0} до {1}:.
        /// </summary>
        internal static string InputNumber {
            get {
                return ResourceManager.GetString("InputNumber", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Загаданное число меньше!.
        /// </summary>
        internal static string Less {
            get {
                return ResourceManager.GetString("Less", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Вы проиграли :-( потратив все {0} попыток.
        /// </summary>
        internal static string Lose {
            get {
                return ResourceManager.GetString("Lose", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Загаданное число больше!.
        /// </summary>
        internal static string More {
            get {
                return ResourceManager.GetString("More", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Введите &quot;N&quot; для новой игры или &quot;Q&quot; для выхода:.
        /// </summary>
        internal static string NewGame {
            get {
                return ResourceManager.GetString("NewGame", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to     1. Игра угадай число
        ///    2. Игра угадай число с ограниченным количеством попыток
        ///Введите номер игры или &quot;Q&quot; для выхода:.
        /// </summary>
        internal static string SelectGame {
            get {
                return ResourceManager.GetString("SelectGame", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Добро пожаловать в консольные игры!.
        /// </summary>
        internal static string Welcome {
            get {
                return ResourceManager.GetString("Welcome", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &quot;Конгратюлэйшэнс!!! Вы угадали число!&quot;.
        /// </summary>
        internal static string Win {
            get {
                return ResourceManager.GetString("Win", resourceCulture);
            }
        }
    }
}
