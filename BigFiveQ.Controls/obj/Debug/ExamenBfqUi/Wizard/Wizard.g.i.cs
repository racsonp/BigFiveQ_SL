﻿#pragma checksum "E:\Projects\BigFiveQ\scr\BigFiveQ.Controls\ExamenBfqUi\Wizard\Wizard.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D5F17A612D6486F8A2D3EA1EFA1AEEC6"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.225
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using BigFiveQ.Controls.ExamenBfqUi;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace BigFiveQ.Controls.ExamenBfqUi.Wizard {
    
    
    public partial class Wizard : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.TextBlock txtTitle;
        
        internal BigFiveQ.Controls.ExamenBfqUi.SwitcherControl ctrPageHost;
        
        internal System.Windows.Controls.Button btNext;
        
        internal System.Windows.Controls.Button btPrevious;
        
        internal System.Windows.Controls.Button btTest;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/BigFiveQ.Controls;component/ExamenBfqUi/Wizard/Wizard.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.txtTitle = ((System.Windows.Controls.TextBlock)(this.FindName("txtTitle")));
            this.ctrPageHost = ((BigFiveQ.Controls.ExamenBfqUi.SwitcherControl)(this.FindName("ctrPageHost")));
            this.btNext = ((System.Windows.Controls.Button)(this.FindName("btNext")));
            this.btPrevious = ((System.Windows.Controls.Button)(this.FindName("btPrevious")));
            this.btTest = ((System.Windows.Controls.Button)(this.FindName("btTest")));
        }
    }
}

