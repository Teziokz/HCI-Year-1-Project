﻿#pragma checksum "..\..\WithdrawWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "FFD5977B9A9BD5A0F1A919027BA591914D301066"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ATMProject;
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


namespace ATMProject {
    
    
    /// <summary>
    /// WithdrawWindow
    /// </summary>
    public partial class WithdrawWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
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
            System.Uri resourceLocater = new System.Uri("/ATMProject;component/withdrawwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\WithdrawWindow.xaml"
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
            
            #line 10 "..\..\WithdrawWindow.xaml"
            ((ATMProject.WithdrawWindow)(target)).ContentRendered += new System.EventHandler(this.Window_ContentRendered);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 13 "..\..\WithdrawWindow.xaml"
            ((System.Windows.Controls.Border)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.exitButtonPush);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 30 "..\..\WithdrawWindow.xaml"
            ((System.Windows.Controls.Label)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.WithdrawButtonPush);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 33 "..\..\WithdrawWindow.xaml"
            ((System.Windows.Controls.Label)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.WithdrawButtonPush);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 36 "..\..\WithdrawWindow.xaml"
            ((System.Windows.Controls.Label)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.WithdrawButtonPush);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 39 "..\..\WithdrawWindow.xaml"
            ((System.Windows.Controls.Label)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.customAmountButtonPush);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 42 "..\..\WithdrawWindow.xaml"
            ((System.Windows.Controls.Label)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.WithdrawButtonPush);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 45 "..\..\WithdrawWindow.xaml"
            ((System.Windows.Controls.Label)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.WithdrawButtonPush);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 48 "..\..\WithdrawWindow.xaml"
            ((System.Windows.Controls.Label)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.WithdrawButtonPush);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 51 "..\..\WithdrawWindow.xaml"
            ((System.Windows.Controls.Label)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.WithdrawButtonPush);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 54 "..\..\WithdrawWindow.xaml"
            ((System.Windows.Controls.Border)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.backButtonPush);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

