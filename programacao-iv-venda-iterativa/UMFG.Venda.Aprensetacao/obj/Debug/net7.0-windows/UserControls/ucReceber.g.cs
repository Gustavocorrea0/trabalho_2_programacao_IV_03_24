﻿#pragma checksum "..\..\..\..\UserControls\ucReceber.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22398EC729AB2AE88E15D77CB074C1A7549D76C5"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
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
using UMFG.Venda.Aprensetacao.UserControls;


namespace UMFG.Venda.Aprensetacao.UserControls {
    
    
    /// <summary>
    /// ucReceber
    /// </summary>
    public partial class ucReceber : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 145 "..\..\..\..\UserControls\ucReceber.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox TipoDePagamento;
        
        #line default
        #line hidden
        
        
        #line 153 "..\..\..\..\UserControls\ucReceber.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NumeroCartao;
        
        #line default
        #line hidden
        
        
        #line 156 "..\..\..\..\UserControls\ucReceber.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CartaoCVV;
        
        #line default
        #line hidden
        
        
        #line 159 "..\..\..\..\UserControls\ucReceber.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ValidadeDoCartao;
        
        #line default
        #line hidden
        
        
        #line 162 "..\..\..\..\UserControls\ucReceber.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NomeCartao;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.9.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/UMFG.Venda.Aprensetacao;component/usercontrols/ucreceber.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\UserControls\ucReceber.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.9.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.TipoDePagamento = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.NumeroCartao = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.CartaoCVV = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.ValidadeDoCartao = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.NomeCartao = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            
            #line 164 "..\..\..\..\UserControls\ucReceber.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Finalizar);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
