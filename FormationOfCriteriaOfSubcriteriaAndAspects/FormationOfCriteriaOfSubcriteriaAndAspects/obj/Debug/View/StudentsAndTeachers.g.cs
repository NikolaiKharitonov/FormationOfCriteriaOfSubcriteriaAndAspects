﻿#pragma checksum "..\..\..\View\StudentsAndTeachers.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4CAED0EB176B2BE9D973F8088A390ED14BCAB1566200D69FC9C3DFA81ED96C79"
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
    /// StudentsAndTeachers
    /// </summary>
    public partial class StudentsAndTeachers : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 22 "..\..\..\View\StudentsAndTeachers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboBoxGroup;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\View\StudentsAndTeachers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboBoxStatusStudent;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\View\StudentsAndTeachers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Header;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\View\StudentsAndTeachers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGridStudents;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\View\StudentsAndTeachers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGridTeacher;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\View\StudentsAndTeachers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboBoxStatusTeacher;
        
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
            System.Uri resourceLocater = new System.Uri("/FormationOfCriteriaOfSubcriteriaAndAspects;component/view/studentsandteachers.xa" +
                    "ml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\StudentsAndTeachers.xaml"
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
            this.ComboBoxGroup = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.ComboBoxStatusStudent = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.Header = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.DataGridStudents = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 6:
            this.DataGridTeacher = ((System.Windows.Controls.DataGrid)(target));
            
            #line 52 "..\..\..\View\StudentsAndTeachers.xaml"
            this.DataGridTeacher.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DataGridTeacher_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.ComboBoxStatusTeacher = ((System.Windows.Controls.ComboBox)(target));
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
            case 5:
            
            #line 44 "..\..\..\View\StudentsAndTeachers.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.RemoveStudentButton_Click);
            
            #line default
            #line hidden
            break;
            case 7:
            
            #line 61 "..\..\..\View\StudentsAndTeachers.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.RegactorTeacherButton_Click);
            
            #line default
            #line hidden
            break;
            case 8:
            
            #line 70 "..\..\..\View\StudentsAndTeachers.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.RemoveTeacherButton_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

