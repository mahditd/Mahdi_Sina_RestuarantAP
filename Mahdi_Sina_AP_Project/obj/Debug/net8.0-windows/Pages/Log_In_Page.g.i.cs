﻿#pragma checksum "..\..\..\..\Pages\Log_In_Page.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6896DC887E7EB30D5283126BDC9A113A43EBE920"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Mahdi_Sina_AP_Project;
using Mahdi_Sina_AP_Project.Pages;
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


namespace Mahdi_Sina_AP_Project.Pages {
    
    
    /// <summary>
    /// Log_In_Page
    /// </summary>
    public partial class Log_In_Page : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 65 "..\..\..\..\Pages\Log_In_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Mahdi_Sina_AP_Project.txtBoxWithTxtBlock UserName;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\..\Pages\Log_In_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Mahdi_Sina_AP_Project.PasswordWithTextBlock Password;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\..\Pages\Log_In_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Mahdi_Sina_AP_Project.NavButton2 confirmBtn;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\..\Pages\Log_In_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Mahdi_Sina_AP_Project.NavButton2 signUpBtn;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Mahdi_Sina_AP_Project;V1.0.0.0;component/pages/log_in_page.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\Log_In_Page.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.1.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.UserName = ((Mahdi_Sina_AP_Project.txtBoxWithTxtBlock)(target));
            return;
            case 2:
            this.Password = ((Mahdi_Sina_AP_Project.PasswordWithTextBlock)(target));
            return;
            case 3:
            this.confirmBtn = ((Mahdi_Sina_AP_Project.NavButton2)(target));
            
            #line 67 "..\..\..\..\Pages\Log_In_Page.xaml"
            this.confirmBtn.AddHandler(System.Windows.Controls.Primitives.ButtonBase.ClickEvent, new System.Windows.RoutedEventHandler(this.confirmBtn_Click_1));
            
            #line default
            #line hidden
            return;
            case 4:
            this.signUpBtn = ((Mahdi_Sina_AP_Project.NavButton2)(target));
            
            #line 69 "..\..\..\..\Pages\Log_In_Page.xaml"
            this.signUpBtn.AddHandler(System.Windows.Controls.Primitives.ButtonBase.ClickEvent, new System.Windows.RoutedEventHandler(this.signUpBtn_Click));
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 71 "..\..\..\..\Pages\Log_In_Page.xaml"
            ((System.Windows.Controls.ComboBoxItem)(target)).PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.customerCombo_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 76 "..\..\..\..\Pages\Log_In_Page.xaml"
            ((System.Windows.Controls.ComboBoxItem)(target)).PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.restaurantCombo_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 81 "..\..\..\..\Pages\Log_In_Page.xaml"
            ((System.Windows.Controls.ComboBoxItem)(target)).PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.adminCombo_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

