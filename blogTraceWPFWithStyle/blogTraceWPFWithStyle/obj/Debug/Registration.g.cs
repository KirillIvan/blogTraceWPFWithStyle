﻿#pragma checksum "..\..\Registration.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "ADD2C9D6FF7703519D3DDEA14AD809FAEE325649E22D78791E16CDC89BC16100"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace blogTraceWPFWithStyle {
    
    
    /// <summary>
    /// Registration
    /// </summary>
    public partial class Registration : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 55 "..\..\Registration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nameBox;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\Registration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox surnameBox;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\Registration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox cityBox;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\Registration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ageBox;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\Registration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox logoBox;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\Registration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox pswdBox;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\Registration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox dPswdBox;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\Registration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnReg;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/blogTraceWPFWithStyle;component/registration.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Registration.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.nameBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 55 "..\..\Registration.xaml"
            this.nameBox.GotFocus += new System.Windows.RoutedEventHandler(this.NameBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 55 "..\..\Registration.xaml"
            this.nameBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.NameBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.surnameBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 56 "..\..\Registration.xaml"
            this.surnameBox.GotFocus += new System.Windows.RoutedEventHandler(this.SurnameBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 56 "..\..\Registration.xaml"
            this.surnameBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.NameBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.cityBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 57 "..\..\Registration.xaml"
            this.cityBox.GotFocus += new System.Windows.RoutedEventHandler(this.CityBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 57 "..\..\Registration.xaml"
            this.cityBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.NameBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ageBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 58 "..\..\Registration.xaml"
            this.ageBox.GotFocus += new System.Windows.RoutedEventHandler(this.AgeBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 58 "..\..\Registration.xaml"
            this.ageBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.NameBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.logoBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 59 "..\..\Registration.xaml"
            this.logoBox.GotFocus += new System.Windows.RoutedEventHandler(this.LogoBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 59 "..\..\Registration.xaml"
            this.logoBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.NameBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.pswdBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 60 "..\..\Registration.xaml"
            this.pswdBox.GotFocus += new System.Windows.RoutedEventHandler(this.PswdBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 60 "..\..\Registration.xaml"
            this.pswdBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.NameBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.dPswdBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 61 "..\..\Registration.xaml"
            this.dPswdBox.GotFocus += new System.Windows.RoutedEventHandler(this.DPswdBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 61 "..\..\Registration.xaml"
            this.dPswdBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.NameBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnReg = ((System.Windows.Controls.Button)(target));
            
            #line 62 "..\..\Registration.xaml"
            this.btnReg.Click += new System.Windows.RoutedEventHandler(this.BtnReg_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

