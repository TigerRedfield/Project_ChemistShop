﻿#pragma checksum "..\..\..\View\TotalOrderWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "59A44BC5DD85B9EB03872BA65427BDAE8BE0163F52C191774F5220042CFADC31"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using ChemistShop.View;
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


namespace ChemistShop.View {
    
    
    /// <summary>
    /// TotalOrderWindow
    /// </summary>
    public partial class TotalOrderWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 30 "..\..\..\View\TotalOrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButExit;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\View\TotalOrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgOrder;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\View\TotalOrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbOrderLast;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\View\TotalOrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tb_summOrder;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\View\TotalOrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Cataloge;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\View\TotalOrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Order;
        
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
            System.Uri resourceLocater = new System.Uri("/ChemistShop;component/view/totalorderwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\TotalOrderWindow.xaml"
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
            this.ButExit = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\View\TotalOrderWindow.xaml"
            this.ButExit.Click += new System.Windows.RoutedEventHandler(this.ButExit_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.dgOrder = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 6:
            this.tbOrderLast = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.tb_summOrder = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.Cataloge = ((System.Windows.Controls.Button)(target));
            
            #line 68 "..\..\..\View\TotalOrderWindow.xaml"
            this.Cataloge.Click += new System.Windows.RoutedEventHandler(this.Cataloge_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Order = ((System.Windows.Controls.Button)(target));
            
            #line 75 "..\..\..\View\TotalOrderWindow.xaml"
            this.Order.Click += new System.Windows.RoutedEventHandler(this.Order_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 3:
            
            #line 53 "..\..\..\View\TotalOrderWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.button_three_function_click);
            
            #line default
            #line hidden
            break;
            case 4:
            
            #line 54 "..\..\..\View\TotalOrderWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.button_three_function_click);
            
            #line default
            #line hidden
            break;
            case 5:
            
            #line 55 "..\..\..\View\TotalOrderWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.button_three_function_click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

