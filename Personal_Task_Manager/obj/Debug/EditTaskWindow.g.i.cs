﻿#pragma checksum "..\..\EditTaskWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1AAA2EB4EF774A08F354F601CC3309882F9750C0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Personal_Task_Manager;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace Personal_Task_Manager {
    
    
    /// <summary>
    /// EditTaskWindow
    /// </summary>
    public partial class EditTaskWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\EditTaskWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button UpdateBtn;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\EditTaskWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label descriptionLbl;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\EditTaskWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox editDescriptionTbox;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\EditTaskWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label startTimeLbl;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\EditTaskWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label endTimeLbl;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\EditTaskWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox editGroupCb;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\EditTaskWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label addTaskGroupLbl;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\EditTaskWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox editStartTimeTbox;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\EditTaskWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox editEndTimeTbox;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\EditTaskWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GroupBox taskInfoGb;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\EditTaskWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox editTaskNameTbox;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\EditTaskWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label taskNameLbl;
        
        #line default
        #line hidden
        
        
        #line 113 "..\..\EditTaskWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Expander editDateExp;
        
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
            System.Uri resourceLocater = new System.Uri("/Personal_Task_Manager;component/edittaskwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\EditTaskWindow.xaml"
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
            this.UpdateBtn = ((System.Windows.Controls.Button)(target));
            return;
            case 2:
            this.descriptionLbl = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.editDescriptionTbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.startTimeLbl = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.endTimeLbl = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.editGroupCb = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.addTaskGroupLbl = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.editStartTimeTbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.editEndTimeTbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.taskInfoGb = ((System.Windows.Controls.GroupBox)(target));
            return;
            case 11:
            this.editTaskNameTbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            this.taskNameLbl = ((System.Windows.Controls.Label)(target));
            return;
            case 13:
            this.editDateExp = ((System.Windows.Controls.Expander)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

