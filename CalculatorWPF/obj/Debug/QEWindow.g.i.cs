﻿#pragma checksum "..\..\QEWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "59DDD5EBF41C7F1525DECC0C50042E7974B87CC4E5CF5D0001924FB82902CC68"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using CalculatorWPF;
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


namespace CalculatorWPF {
    
    
    /// <summary>
    /// QEWindow
    /// </summary>
    public partial class QEWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\QEWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal CalculatorWPF.QEWindow QEWindow1;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\QEWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxA;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\QEWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxB;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\QEWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxC;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\QEWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox richTextBox1;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\QEWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CalcButton;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\QEWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonCancel;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\QEWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonClear;
        
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
            System.Uri resourceLocater = new System.Uri("/CalculatorWPF;component/qewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\QEWindow.xaml"
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
            this.QEWindow1 = ((CalculatorWPF.QEWindow)(target));
            return;
            case 2:
            this.textBoxA = ((System.Windows.Controls.TextBox)(target));
            
            #line 20 "..\..\QEWindow.xaml"
            this.textBoxA.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.textBoxA_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 3:
            this.textBoxB = ((System.Windows.Controls.TextBox)(target));
            
            #line 21 "..\..\QEWindow.xaml"
            this.textBoxB.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.textBoxB_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 4:
            this.textBoxC = ((System.Windows.Controls.TextBox)(target));
            
            #line 22 "..\..\QEWindow.xaml"
            this.textBoxC.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.textBoxC_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 5:
            this.richTextBox1 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.CalcButton = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\QEWindow.xaml"
            this.CalcButton.Click += new System.Windows.RoutedEventHandler(this.CalcButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ButtonCancel = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\QEWindow.xaml"
            this.ButtonCancel.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ButtonClear = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\QEWindow.xaml"
            this.ButtonClear.Click += new System.Windows.RoutedEventHandler(this.ButtonClear_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
