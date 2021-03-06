﻿#pragma checksum "..\..\TimerSettingsWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "035D9F8E444FE53B4B2BB8150D414CE29DFDE95E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Personal_Calendar;
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


namespace Personal_Calendar {
    
    
    /// <summary>
    /// TimerSettingsWindow
    /// </summary>
    public partial class TimerSettingsWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\TimerSettingsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image plainAlarmImage;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\TimerSettingsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image turboAlarmImage;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\TimerSettingsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image softAlarmImage;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\TimerSettingsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image relaxingAlarmImage;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\TimerSettingsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image groovyAlarmImage;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\TimerSettingsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label plainAlarmLabel;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\TimerSettingsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label turboAlarmLabel;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\TimerSettingsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label softAlarmLabel;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\TimerSettingsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label quietAlarmLabel;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\TimerSettingsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label groovyAlarmLabel;
        
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
            System.Uri resourceLocater = new System.Uri("/Personal Calendar;component/timersettingswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\TimerSettingsWindow.xaml"
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
            
            #line 8 "..\..\TimerSettingsWindow.xaml"
            ((Personal_Calendar.TimerSettingsWindow)(target)).Closed += new System.EventHandler(this.Window_Closed);
            
            #line default
            #line hidden
            
            #line 8 "..\..\TimerSettingsWindow.xaml"
            ((Personal_Calendar.TimerSettingsWindow)(target)).Activated += new System.EventHandler(this.Window_Activated);
            
            #line default
            #line hidden
            return;
            case 2:
            this.plainAlarmImage = ((System.Windows.Controls.Image)(target));
            
            #line 21 "..\..\TimerSettingsWindow.xaml"
            this.plainAlarmImage.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.plainAlarmImage_MouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 3:
            this.turboAlarmImage = ((System.Windows.Controls.Image)(target));
            
            #line 22 "..\..\TimerSettingsWindow.xaml"
            this.turboAlarmImage.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.turboAlarmImage_MouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 4:
            this.softAlarmImage = ((System.Windows.Controls.Image)(target));
            
            #line 23 "..\..\TimerSettingsWindow.xaml"
            this.softAlarmImage.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.softAlarmImage_MouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 5:
            this.relaxingAlarmImage = ((System.Windows.Controls.Image)(target));
            
            #line 24 "..\..\TimerSettingsWindow.xaml"
            this.relaxingAlarmImage.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.relaxingAlarmImage_MouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 6:
            this.groovyAlarmImage = ((System.Windows.Controls.Image)(target));
            
            #line 25 "..\..\TimerSettingsWindow.xaml"
            this.groovyAlarmImage.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.groovyAlarmImage_MouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 7:
            this.plainAlarmLabel = ((System.Windows.Controls.Label)(target));
            
            #line 26 "..\..\TimerSettingsWindow.xaml"
            this.plainAlarmLabel.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.plainAlarmLabel_MouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 8:
            this.turboAlarmLabel = ((System.Windows.Controls.Label)(target));
            
            #line 27 "..\..\TimerSettingsWindow.xaml"
            this.turboAlarmLabel.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.turboAlarmLabel_MouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 9:
            this.softAlarmLabel = ((System.Windows.Controls.Label)(target));
            
            #line 28 "..\..\TimerSettingsWindow.xaml"
            this.softAlarmLabel.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.softAlarmLabel_MouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 10:
            this.quietAlarmLabel = ((System.Windows.Controls.Label)(target));
            
            #line 29 "..\..\TimerSettingsWindow.xaml"
            this.quietAlarmLabel.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.quietAlarmLabel_MouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 11:
            this.groovyAlarmLabel = ((System.Windows.Controls.Label)(target));
            
            #line 30 "..\..\TimerSettingsWindow.xaml"
            this.groovyAlarmLabel.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.groovyAlarmLabel_MouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

