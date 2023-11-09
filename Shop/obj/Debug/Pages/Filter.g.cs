﻿#pragma checksum "..\..\..\Pages\Filter.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2D39240DA5B8268CBAA07E981A341F08E32BF6904FD2AB81747DF57F4570A135"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Shop.Pages;
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


namespace Shop.Pages {
    
    
    /// <summary>
    /// Filter
    /// </summary>
    public partial class Filter : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\Pages\Filter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox SortCb;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Pages\Filter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox DiscountFilterCb;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Pages\Filter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchTb;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Pages\Filter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.WrapPanel ProductsWp;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\Pages\Filter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddBtn;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\Pages\Filter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock CountDataTb;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\Pages\Filter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BasketBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/Shop;component/pages/filter.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\Filter.xaml"
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
            this.SortCb = ((System.Windows.Controls.ComboBox)(target));
            
            #line 18 "..\..\..\Pages\Filter.xaml"
            this.SortCb.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.SortCb_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.DiscountFilterCb = ((System.Windows.Controls.ComboBox)(target));
            
            #line 24 "..\..\..\Pages\Filter.xaml"
            this.DiscountFilterCb.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DiscountFilterCb_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.SearchTb = ((System.Windows.Controls.TextBox)(target));
            
            #line 33 "..\..\..\Pages\Filter.xaml"
            this.SearchTb.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.SearchTb_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ProductsWp = ((System.Windows.Controls.WrapPanel)(target));
            return;
            case 5:
            this.AddBtn = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\Pages\Filter.xaml"
            this.AddBtn.Click += new System.Windows.RoutedEventHandler(this.AddBtn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.CountDataTb = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.BasketBtn = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\..\Pages\Filter.xaml"
            this.BasketBtn.Click += new System.Windows.RoutedEventHandler(this.BasketBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

