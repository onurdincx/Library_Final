﻿#pragma checksum "..\..\..\AdminPanel.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "125D9CD6197643AED054ADADF75E251191DA2E3D"
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
    /// AdminPanel
    /// </summary>
    public partial class AdminPanel : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\AdminPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GroupBox gbox_Member;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\AdminPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_AddMember;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\AdminPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_ListMember;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\AdminPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GroupBox gbox_Books;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\AdminPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_AddBook;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\AdminPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_ListBook;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\AdminPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GroupBox gbox_DepositBook;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\AdminPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_GiveBook;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\AdminPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_ListDepositBooks;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\AdminPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Close_AdminPanel;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\AdminPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_ReturnDepositBook_AdminPanel;
        
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
            System.Uri resourceLocater = new System.Uri("/Library_Final;component/adminpanel.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\AdminPanel.xaml"
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
            this.gbox_Member = ((System.Windows.Controls.GroupBox)(target));
            return;
            case 2:
            this.btn_AddMember = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\AdminPanel.xaml"
            this.btn_AddMember.Click += new System.Windows.RoutedEventHandler(this.btn_AddMember_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btn_ListMember = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\AdminPanel.xaml"
            this.btn_ListMember.Click += new System.Windows.RoutedEventHandler(this.btn_ListMember_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.gbox_Books = ((System.Windows.Controls.GroupBox)(target));
            return;
            case 5:
            this.btn_AddBook = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\AdminPanel.xaml"
            this.btn_AddBook.Click += new System.Windows.RoutedEventHandler(this.btn_AddBook_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btn_ListBook = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\AdminPanel.xaml"
            this.btn_ListBook.Click += new System.Windows.RoutedEventHandler(this.btn_ListBook_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.gbox_DepositBook = ((System.Windows.Controls.GroupBox)(target));
            return;
            case 8:
            this.btn_GiveBook = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\AdminPanel.xaml"
            this.btn_GiveBook.Click += new System.Windows.RoutedEventHandler(this.btn_GiveBook_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btn_ListDepositBooks = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\AdminPanel.xaml"
            this.btn_ListDepositBooks.Click += new System.Windows.RoutedEventHandler(this.btn_ListDepositBooks_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btn_Close_AdminPanel = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\AdminPanel.xaml"
            this.btn_Close_AdminPanel.Click += new System.Windows.RoutedEventHandler(this.btn_Close_AdminPanel_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.btn_ReturnDepositBook_AdminPanel = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\..\AdminPanel.xaml"
            this.btn_ReturnDepositBook_AdminPanel.Click += new System.Windows.RoutedEventHandler(this.btn_ReturnDepositBook_AdminPanel_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

