﻿#pragma checksum "..\..\..\..\..\Pages\userControls\ComplaintsPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D7F337A1A0FDEEA77ECAD1D76287429ADF9F8CB0"
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
using Mahdi_Sina_AP_Project.Pages.userControls;
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


namespace Mahdi_Sina_AP_Project.Pages.userControls {
    
    
    /// <summary>
    /// ComplaintsPage
    /// </summary>
    public partial class ComplaintsPage : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\..\..\Pages\userControls\ComplaintsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox complaintText;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\..\Pages\userControls\ComplaintsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Mahdi_Sina_AP_Project.txtBoxWithTxtBlock restaurantName;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\..\Pages\userControls\ComplaintsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SubmitComplaint;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\..\Pages\userControls\ComplaintsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button complaintHistory;
        
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
            System.Uri resourceLocater = new System.Uri("/Mahdi_Sina_AP_Project;component/pages/usercontrols/complaintspage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Pages\userControls\ComplaintsPage.xaml"
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
            this.complaintText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.restaurantName = ((Mahdi_Sina_AP_Project.txtBoxWithTxtBlock)(target));
            return;
            case 3:
            this.SubmitComplaint = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\..\..\Pages\userControls\ComplaintsPage.xaml"
            this.SubmitComplaint.Click += new System.Windows.RoutedEventHandler(this.SubmitComplaint_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.complaintHistory = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\..\..\Pages\userControls\ComplaintsPage.xaml"
            this.complaintHistory.Click += new System.Windows.RoutedEventHandler(this.complaintHistory_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

