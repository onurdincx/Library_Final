﻿#pragma checksum "..\..\..\AdminPanel_AddMember.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53134C320D7DC3E2D26FCC21203B8DFA42CE6236"
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
    /// AdminPanel_AddMember
    /// </summary>
    public partial class AdminPanel_AddMember : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\AdminPanel_AddMember.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_Name_Admin;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\AdminPanel_AddMember.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_SurName_Admin;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\AdminPanel_AddMember.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_Number_Admin;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\AdminPanel_AddMember.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_Mail_Admin;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\AdminPanel_AddMember.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_Password_Admin;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\AdminPanel_AddMember.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox combobox_MemberType_Admin;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\AdminPanel_AddMember.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_AddMember_Admin;
        
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
            System.Uri resourceLocater = new System.Uri("/Library_Final;component/adminpanel_addmember.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\AdminPanel_AddMember.xaml"
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
            this.txt_Name_Admin = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txt_SurName_Admin = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txt_Number_Admin = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txt_Mail_Admin = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txt_Password_Admin = ((System.Windows.Controls.TextBox)(target));
            
            #line 20 "..\..\..\AdminPanel_AddMember.xaml"
            this.txt_Password_Admin.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txt_Password_Admin_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.combobox_MemberType_Admin = ((System.Windows.Controls.ComboBox)(target));
            
            #line 22 "..\..\..\AdminPanel_AddMember.xaml"
            this.combobox_MemberType_Admin.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.combobox_MemberType_Admin_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btn_AddMember_Admin = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\AdminPanel_AddMember.xaml"
            this.btn_AddMember_Admin.Click += new System.Windows.RoutedEventHandler(this.btn_AddMember_Admin_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 36 "..\..\..\AdminPanel_AddMember.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
