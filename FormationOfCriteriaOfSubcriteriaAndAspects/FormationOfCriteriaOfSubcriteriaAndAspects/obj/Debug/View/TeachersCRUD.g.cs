﻿#pragma checksum "..\..\..\View\TeachersCRUD.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "18DADF215E944008C424A6EFFCFC42B6B0743016160FAA3BF90F915874971F87"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using FormationOfCriteriaOfSubcriteriaAndAspects.View;
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


namespace FormationOfCriteriaOfSubcriteriaAndAspects.View {
    
    
    /// <summary>
    /// TeachersCRUD
    /// </summary>
    public partial class TeachersCRUD : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 20 "..\..\..\View\TeachersCRUD.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button NazadTeachersButton;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\View\TeachersCRUD.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddTeachersButton;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\View\TeachersCRUD.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboBoxStatusTeacher;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\View\TeachersCRUD.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Header;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\View\TeachersCRUD.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGridTeacher;
        
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
            System.Uri resourceLocater = new System.Uri("/FormationOfCriteriaOfSubcriteriaAndAspects;component/view/teacherscrud.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\TeachersCRUD.xaml"
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
            this.NazadTeachersButton = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\View\TeachersCRUD.xaml"
            this.NazadTeachersButton.Click += new System.Windows.RoutedEventHandler(this.NazadTeachersButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.AddTeachersButton = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\View\TeachersCRUD.xaml"
            this.AddTeachersButton.Click += new System.Windows.RoutedEventHandler(this.AddTeachersButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ComboBoxStatusTeacher = ((System.Windows.Controls.ComboBox)(target));
            
            #line 22 "..\..\..\View\TeachersCRUD.xaml"
            this.ComboBoxStatusTeacher.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBoxStatusTeacher_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Header = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.DataGridTeacher = ((System.Windows.Controls.DataGrid)(target));
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
            case 6:
            
            #line 38 "..\..\..\View\TeachersCRUD.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.RegactorStudentButton_Click);
            
            #line default
            #line hidden
            break;
            case 7:
            
            #line 47 "..\..\..\View\TeachersCRUD.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.RemoveTeacherButton_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

