﻿#pragma checksum "..\..\..\..\..\Pages\userControls\AddFood.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5BD32BA7D9F206A2EA07D4E007301233F59DF157"
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
    /// AddFood
    /// </summary>
    public partial class AddFood : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\..\..\..\Pages\userControls\AddFood.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Mahdi_Sina_AP_Project.txtBoxWithTxtBlock name;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\..\Pages\userControls\AddFood.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Mahdi_Sina_AP_Project.txtBoxWithTxtBlock price;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\..\Pages\userControls\AddFood.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Mahdi_Sina_AP_Project.txtBoxWithTxtBlock ingradients;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\..\..\Pages\userControls\AddFood.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ImportImage;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\..\..\Pages\userControls\AddFood.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Image;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\..\..\Pages\userControls\AddFood.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Mahdi_Sina_AP_Project.txtBoxWithTxtBlock restaurantUserName;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\..\..\Pages\userControls\AddFood.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button confirmBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/Mahdi_Sina_AP_Project;component/pages/usercontrols/addfood.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Pages\userControls\AddFood.xaml"
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
            this.name = ((Mahdi_Sina_AP_Project.txtBoxWithTxtBlock)(target));
            return;
            case 2:
            this.price = ((Mahdi_Sina_AP_Project.txtBoxWithTxtBlock)(target));
            return;
            case 3:
            this.ingradients = ((Mahdi_Sina_AP_Project.txtBoxWithTxtBlock)(target));
            return;
            case 4:
            this.ImportImage = ((System.Windows.Controls.Button)(target));
            
            #line 56 "..\..\..\..\..\Pages\userControls\AddFood.xaml"
            this.ImportImage.Click += new System.Windows.RoutedEventHandler(this.ImportImage_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Image = ((System.Windows.Controls.Image)(target));
            return;
            case 6:
            this.restaurantUserName = ((Mahdi_Sina_AP_Project.txtBoxWithTxtBlock)(target));
            return;
            case 7:
            this.confirmBtn = ((System.Windows.Controls.Button)(target));
            
            #line 62 "..\..\..\..\..\Pages\userControls\AddFood.xaml"
            this.confirmBtn.Click += new System.Windows.RoutedEventHandler(this.confirmBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
