#pragma checksum "..\..\DonutChart.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7C17AF9ECDE9AB707DDC7A5FE9CE6DCD9070A0B07EF4011D9F51B842C19C0271"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Expression.Controls;
using Microsoft.Expression.Media;
using Microsoft.Expression.Shapes;
using SimpleDonutChart;
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


namespace SimpleDonutChart {
    
    
    /// <summary>
    /// DonutChart
    /// </summary>
    public partial class DonutChart : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\DonutChart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal SimpleDonutChart.DonutChart UserControl;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\DonutChart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Expression.Shapes.Arc outer;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\DonutChart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Expression.Shapes.Arc inner;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\DonutChart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock InnererTextblock;
        
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
            System.Uri resourceLocater = new System.Uri("/SimpleDonutChart;component/donutchart.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\DonutChart.xaml"
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
            this.UserControl = ((SimpleDonutChart.DonutChart)(target));
            return;
            case 2:
            this.outer = ((Microsoft.Expression.Shapes.Arc)(target));
            return;
            case 3:
            this.inner = ((Microsoft.Expression.Shapes.Arc)(target));
            return;
            case 4:
            this.InnererTextblock = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

