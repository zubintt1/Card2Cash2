﻿#pragma checksum "..\..\PayForm1.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "514B53FB9BB12938E4578F7017AA9C9D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace Card2Cash2 {
    
    
    /// <summary>
    /// PayForm1
    /// </summary>
    public partial class PayForm1 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\PayForm1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label request_lbl2;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\PayForm1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox numver2_txtbx;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\PayForm1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label request_lbl3;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\PayForm1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox amount_txtbx1;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\PayForm1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button back_btn1;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\PayForm1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button pay_btn1;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\PayForm1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock result_txtbx1;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\PayForm1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Failure_lbl1;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\PayForm1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Success_lbl1;
        
        #line default
        #line hidden
        
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
            System.Uri resourceLocater = new System.Uri("/Card2Cash2;component/payform1.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\PayForm1.xaml"
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
            this.request_lbl2 = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.numver2_txtbx = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.request_lbl3 = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.amount_txtbx1 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.back_btn1 = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\PayForm1.xaml"
            this.back_btn1.Click += new System.Windows.RoutedEventHandler(this.back_btn1_Click_1);
            
            #line default
            #line hidden
            return;
            case 6:
            this.pay_btn1 = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\PayForm1.xaml"
            this.pay_btn1.Click += new System.Windows.RoutedEventHandler(this.pay_btn1_Click_1);
            
            #line default
            #line hidden
            return;
            case 7:
            this.result_txtbx1 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.Failure_lbl1 = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.Success_lbl1 = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
