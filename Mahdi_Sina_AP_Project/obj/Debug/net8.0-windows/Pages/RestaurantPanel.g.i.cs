﻿#pragma checksum "..\..\..\..\Pages\RestaurantPanel.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F984BC06911BDC6E36E391619CF9547DFF8E82F5"
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
    /// RestaurantPanel
    /// </summary>
    public partial class RestaurantPanel : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 33 "..\..\..\..\Pages\RestaurantPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Mahdi_Sina_AP_Project.NavButton2 ChangeButton;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\Pages\RestaurantPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Mahdi_Sina_AP_Project.NavButton2 ChangeButton2;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\Pages\RestaurantPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button HistoryButton;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\Pages\RestaurantPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CircleButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.6.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Mahdi_Sina_AP_Project;component/pages/restaurantpanel.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\RestaurantPanel.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.6.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.6.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.ChangeButton = ((Mahdi_Sina_AP_Project.NavButton2)(target));
            
            #line 33 "..\..\..\..\Pages\RestaurantPanel.xaml"
            this.ChangeButton.AddHandler(System.Windows.Controls.Primitives.ButtonBase.ClickEvent, new System.Windows.RoutedEventHandler(this.ChangeButton_Click));
            
            #line default
            #line hidden
            return;
            case 2:
            this.ChangeButton2 = ((Mahdi_Sina_AP_Project.NavButton2)(target));
            
            #line 34 "..\..\..\..\Pages\RestaurantPanel.xaml"
            this.ChangeButton2.AddHandler(System.Windows.Controls.Primitives.ButtonBase.ClickEvent, new System.Windows.RoutedEventHandler(this.ChangeButton2_Click));
            
            #line default
            #line hidden
            return;
            case 3:
            this.HistoryButton = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\..\Pages\RestaurantPanel.xaml"
            this.HistoryButton.Click += new System.Windows.RoutedEventHandler(this.HistoryButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.CircleButton = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\..\..\Pages\RestaurantPanel.xaml"
            this.CircleButton.Click += new System.Windows.RoutedEventHandler(this.CircleButton_Click);
            
            #line default
            #line hidden
            
            #line 38 "..\..\..\..\Pages\RestaurantPanel.xaml"
            this.CircleButton.Loaded += new System.Windows.RoutedEventHandler(this.CircleButton_Loaded);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

