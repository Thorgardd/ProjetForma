﻿#pragma checksum "..\..\..\..\Interfaces\Login.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F76CEED6C92B663C06DB3D486B6B6F494363732B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MahApps.Metro.IconPacks;
using MahApps.Metro.IconPacks.Converter;
using ProjetForma;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace ProjetForma.Interfaces {
    
    
    /// <summary>
    /// Login
    /// </summary>
    public partial class Login : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 54 "..\..\..\..\Interfaces\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Username;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\..\..\Interfaces\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox Password;
        
        #line default
        #line hidden
        
        
        #line 110 "..\..\..\..\Interfaces\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LogStatus;
        
        #line default
        #line hidden
        
        
        #line 121 "..\..\..\..\Interfaces\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button;
        
        #line default
        #line hidden
        
        
        #line 129 "..\..\..\..\Interfaces\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonLeave;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ProjetForma;component/interfaces/login.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Interfaces\Login.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Username = ((System.Windows.Controls.TextBox)(target));
            
            #line 65 "..\..\..\..\Interfaces\Login.xaml"
            this.Username.GotFocus += new System.Windows.RoutedEventHandler(this.Username_OnGotFocus);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Password = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 93 "..\..\..\..\Interfaces\Login.xaml"
            this.Password.GotFocus += new System.Windows.RoutedEventHandler(this.Password_OnGotFocus);
            
            #line default
            #line hidden
            
            #line 94 "..\..\..\..\Interfaces\Login.xaml"
            this.Password.KeyDown += new System.Windows.Input.KeyEventHandler(this.Password_OnKeyDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.LogStatus = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.Button = ((System.Windows.Controls.Button)(target));
            
            #line 122 "..\..\..\..\Interfaces\Login.xaml"
            this.Button.Click += new System.Windows.RoutedEventHandler(this.Button_OnClick);
            
            #line default
            #line hidden
            
            #line 123 "..\..\..\..\Interfaces\Login.xaml"
            this.Button.MouseEnter += new System.Windows.Input.MouseEventHandler(this.Button_OnMouseEnter);
            
            #line default
            #line hidden
            
            #line 124 "..\..\..\..\Interfaces\Login.xaml"
            this.Button.MouseLeave += new System.Windows.Input.MouseEventHandler(this.Button_OnMouseLeave);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ButtonLeave = ((System.Windows.Controls.Button)(target));
            
            #line 131 "..\..\..\..\Interfaces\Login.xaml"
            this.ButtonLeave.MouseEnter += new System.Windows.Input.MouseEventHandler(this.ButtonLeave_OnMouseEnter);
            
            #line default
            #line hidden
            
            #line 132 "..\..\..\..\Interfaces\Login.xaml"
            this.ButtonLeave.MouseLeave += new System.Windows.Input.MouseEventHandler(this.ButtonLeave_OnMouseLeave);
            
            #line default
            #line hidden
            
            #line 133 "..\..\..\..\Interfaces\Login.xaml"
            this.ButtonLeave.Click += new System.Windows.RoutedEventHandler(this.ButtonLeave_OnClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

