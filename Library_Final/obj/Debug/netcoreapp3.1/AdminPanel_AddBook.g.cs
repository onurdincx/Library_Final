﻿#pragma checksum "..\..\..\AdminPanel_AddBook.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4A9333C7B21C6B0D83004288E600CF841B5E7310"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Library_Final;
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


namespace Library_Final {
    
    
    /// <summary>
    /// AdminPanel_AddBook
    /// </summary>
    public partial class AdminPanel_AddBook : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\AdminPanel_AddBook.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_BookName_Admin;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\AdminPanel_AddBook.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_BookPage_Admin;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\AdminPanel_AddBook.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_BookAuthor_Admin;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\AdminPanel_AddBook.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_BookYear_Admin;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\AdminPanel_AddBook.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_BookStock_Admin;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\AdminPanel_AddBook.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_CancelBook_Admin;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\AdminPanel_AddBook.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_AddBook_Admin;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\AdminPanel_AddBook.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox combobox_BookCategory_Admin;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.11.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Library_Final;component/adminpanel_addbook.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\AdminPanel_AddBook.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.11.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.txt_BookName_Admin = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txt_BookPage_Admin = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txt_BookAuthor_Admin = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txt_BookYear_Admin = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txt_BookStock_Admin = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.btn_CancelBook_Admin = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\AdminPanel_AddBook.xaml"
            this.btn_CancelBook_Admin.Click += new System.Windows.RoutedEventHandler(this.btn_CancelBook_Admin_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btn_AddBook_Admin = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\AdminPanel_AddBook.xaml"
            this.btn_AddBook_Admin.Click += new System.Windows.RoutedEventHandler(this.btn_AddBook_Admin_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.combobox_BookCategory_Admin = ((System.Windows.Controls.ComboBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

