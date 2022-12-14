#pragma checksum "..\..\..\Screens\AdminScreen.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9C416749D53AB328A7F2FA80F2266AFEBBD9CDB4B31FD0ED1FCAC59F89BC4C47"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using Shoprite.Screens;
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


namespace Shoprite.Screens {
    
    
    /// <summary>
    /// AdminScreen
    /// </summary>
    public partial class AdminScreen : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 137 "..\..\..\Screens\AdminScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock users;
        
        #line default
        #line hidden
        
        
        #line 146 "..\..\..\Screens\AdminScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock admins;
        
        #line default
        #line hidden
        
        
        #line 206 "..\..\..\Screens\AdminScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock total_tills;
        
        #line default
        #line hidden
        
        
        #line 242 "..\..\..\Screens\AdminScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox idx;
        
        #line default
        #line hidden
        
        
        #line 250 "..\..\..\Screens\AdminScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGrid;
        
        #line default
        #line hidden
        
        
        #line 255 "..\..\..\Screens\AdminScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox typex;
        
        #line default
        #line hidden
        
        
        #line 259 "..\..\..\Screens\AdminScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox itemx;
        
        #line default
        #line hidden
        
        
        #line 263 "..\..\..\Screens\AdminScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox quatityx;
        
        #line default
        #line hidden
        
        
        #line 267 "..\..\..\Screens\AdminScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox pricex;
        
        #line default
        #line hidden
        
        
        #line 271 "..\..\..\Screens\AdminScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox soldx;
        
        #line default
        #line hidden
        
        
        #line 275 "..\..\..\Screens\AdminScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox amountx;
        
        #line default
        #line hidden
        
        
        #line 291 "..\..\..\Screens\AdminScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid sales;
        
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
            System.Uri resourceLocater = new System.Uri("/Shoprite;component/screens/adminscreen.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Screens\AdminScreen.xaml"
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
            
            #line 97 "..\..\..\Screens\AdminScreen.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.back);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 99 "..\..\..\Screens\AdminScreen.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.logback);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 110 "..\..\..\Screens\AdminScreen.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.gotoTill);
            
            #line default
            #line hidden
            return;
            case 4:
            this.users = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.admins = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.total_tills = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            
            #line 230 "..\..\..\Screens\AdminScreen.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.views);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 233 "..\..\..\Screens\AdminScreen.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.update);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 236 "..\..\..\Screens\AdminScreen.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.add);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 239 "..\..\..\Screens\AdminScreen.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.remove);
            
            #line default
            #line hidden
            return;
            case 11:
            this.idx = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            this.dataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 13:
            this.typex = ((System.Windows.Controls.TextBox)(target));
            return;
            case 14:
            this.itemx = ((System.Windows.Controls.TextBox)(target));
            return;
            case 15:
            this.quatityx = ((System.Windows.Controls.TextBox)(target));
            return;
            case 16:
            this.pricex = ((System.Windows.Controls.TextBox)(target));
            return;
            case 17:
            this.soldx = ((System.Windows.Controls.TextBox)(target));
            return;
            case 18:
            this.amountx = ((System.Windows.Controls.TextBox)(target));
            return;
            case 19:
            
            #line 288 "..\..\..\Screens\AdminScreen.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.view_sales);
            
            #line default
            #line hidden
            return;
            case 20:
            this.sales = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

