﻿#pragma checksum "..\..\..\..\view\admpanel.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75FF672D78E450131806B6079EF73C850F9A8D28"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using Rsiglo21.view;
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


namespace Rsiglo21.view {
    
    
    /// <summary>
    /// admpanel
    /// </summary>
    public partial class admpanel : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\..\..\view\admpanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Principal;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\view\admpanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GridMenu;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\view\admpanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton MostrarOcultar;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\view\admpanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.Animation.Storyboard EsconderPanel;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\view\admpanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.Animation.Storyboard MostrarPanel;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\..\view\admpanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton BtnMesas;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\..\..\view\admpanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rdCocina;
        
        #line default
        #line hidden
        
        
        #line 119 "..\..\..\..\view\admpanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rdFinanzas;
        
        #line default
        #line hidden
        
        
        #line 145 "..\..\..\..\view\admpanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton BtnUsuarios;
        
        #line default
        #line hidden
        
        
        #line 170 "..\..\..\..\view\admpanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rdBodega;
        
        #line default
        #line hidden
        
        
        #line 201 "..\..\..\..\view\admpanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame PagesNavigation;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.8.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Rsiglo21;component/view/admpanel.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\view\admpanel.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.8.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Principal = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.GridMenu = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.MostrarOcultar = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            
            #line 23 "..\..\..\..\view\admpanel.xaml"
            this.MostrarOcultar.Checked += new System.Windows.RoutedEventHandler(this.TBShow);
            
            #line default
            #line hidden
            
            #line 24 "..\..\..\..\view\admpanel.xaml"
            this.MostrarOcultar.Unchecked += new System.Windows.RoutedEventHandler(this.TBHide);
            
            #line default
            #line hidden
            return;
            case 4:
            this.EsconderPanel = ((System.Windows.Media.Animation.Storyboard)(target));
            return;
            case 5:
            this.MostrarPanel = ((System.Windows.Media.Animation.Storyboard)(target));
            return;
            case 6:
            this.BtnMesas = ((System.Windows.Controls.RadioButton)(target));
            
            #line 70 "..\..\..\..\view\admpanel.xaml"
            this.BtnMesas.Click += new System.Windows.RoutedEventHandler(this.rdMesas_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.rdCocina = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 8:
            this.rdFinanzas = ((System.Windows.Controls.RadioButton)(target));
            
            #line 120 "..\..\..\..\view\admpanel.xaml"
            this.rdFinanzas.Click += new System.Windows.RoutedEventHandler(this.rdFinanzas_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.BtnUsuarios = ((System.Windows.Controls.RadioButton)(target));
            
            #line 150 "..\..\..\..\view\admpanel.xaml"
            this.BtnUsuarios.Click += new System.Windows.RoutedEventHandler(this.rdUsuarios_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.rdBodega = ((System.Windows.Controls.RadioButton)(target));
            
            #line 171 "..\..\..\..\view\admpanel.xaml"
            this.rdBodega.Click += new System.Windows.RoutedEventHandler(this.rdBodega_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.PagesNavigation = ((System.Windows.Controls.Frame)(target));
            
            #line 201 "..\..\..\..\view\admpanel.xaml"
            this.PagesNavigation.Navigated += new System.Windows.Navigation.NavigatedEventHandler(this.PagesNavigation_Navigated_1);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

