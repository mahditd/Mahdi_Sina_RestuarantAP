﻿#pragma checksum "..\..\..\..\Pages\Food_Inventory.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62816A3189E2B2D17567A45A09EB25B85C8CD15B"
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
    /// Food_Inventory
    /// </summary>
    public partial class Food_Inventory : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 178 "..\..\..\..\Pages\Food_Inventory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox myListBox;
        
        #line default
        #line hidden
        
        
        #line 199 "..\..\..\..\Pages\Food_Inventory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MyDeleteButton;
        
        #line default
        #line hidden
        
        
        #line 202 "..\..\..\..\Pages\Food_Inventory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MyCommentButton;
        
        #line default
        #line hidden
        
        
        #line 214 "..\..\..\..\Pages\Food_Inventory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Image;
        
        #line default
        #line hidden
        
        
        #line 215 "..\..\..\..\Pages\Food_Inventory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ChangeImageButton;
        
        #line default
        #line hidden
        
        
        #line 220 "..\..\..\..\Pages\Food_Inventory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBox1;
        
        #line default
        #line hidden
        
        
        #line 231 "..\..\..\..\Pages\Food_Inventory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBox2;
        
        #line default
        #line hidden
        
        
        #line 245 "..\..\..\..\Pages\Food_Inventory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MySaveButton;
        
        #line default
        #line hidden
        
        
        #line 256 "..\..\..\..\Pages\Food_Inventory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBox3;
        
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
            System.Uri resourceLocater = new System.Uri("/Mahdi_Sina_AP_Project;component/pages/food_inventory.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\Food_Inventory.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
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
            
            #line 170 "..\..\..\..\Pages\Food_Inventory.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.myListBox = ((System.Windows.Controls.ListBox)(target));
            
            #line 178 "..\..\..\..\Pages\Food_Inventory.xaml"
            this.myListBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.myListBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 196 "..\..\..\..\Pages\Food_Inventory.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.New_Food_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.MyDeleteButton = ((System.Windows.Controls.Button)(target));
            
            #line 199 "..\..\..\..\Pages\Food_Inventory.xaml"
            this.MyDeleteButton.Click += new System.Windows.RoutedEventHandler(this.Delete_Food_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.MyCommentButton = ((System.Windows.Controls.Button)(target));
            
            #line 202 "..\..\..\..\Pages\Food_Inventory.xaml"
            this.MyCommentButton.Click += new System.Windows.RoutedEventHandler(this.Comments_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Image = ((System.Windows.Controls.Image)(target));
            return;
            case 7:
            this.ChangeImageButton = ((System.Windows.Controls.Button)(target));
            
            #line 215 "..\..\..\..\Pages\Food_Inventory.xaml"
            this.ChangeImageButton.Click += new System.Windows.RoutedEventHandler(this.ChangeImageButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.TextBox1 = ((System.Windows.Controls.TextBox)(target));
            
            #line 229 "..\..\..\..\Pages\Food_Inventory.xaml"
            this.TextBox1.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox1_TextChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.TextBox2 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.MySaveButton = ((System.Windows.Controls.Button)(target));
            
            #line 245 "..\..\..\..\Pages\Food_Inventory.xaml"
            this.MySaveButton.Click += new System.Windows.RoutedEventHandler(this.SaveButton_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.TextBox3 = ((System.Windows.Controls.TextBox)(target));
            
            #line 265 "..\..\..\..\Pages\Food_Inventory.xaml"
            this.TextBox3.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox3_TextChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

