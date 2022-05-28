using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FormationOfCriteriaOfSubcriteriaAndAspects.View
{
    /// <summary>
    /// Логика взаимодействия для StudentsAndTeachers.xaml
    /// </summary>
    public partial class StudentsAndTeachers : Window
    {
        public StudentsAndTeachers()
        {
            InitializeComponent();
            LoadDataStudent();
            LoadDataTeacher();
        }
        public void LoadDataStudent()
        {
            var criteriaList = Controller.Connect.GetContext().Student.ToList();
            DataGridStudents.ItemsSource = criteriaList;
        }
        public void LoadDataTeacher()
        {
            var cridList = Controller.Connect.GetContext().Teachers.ToList();
            DataGridTeacher.ItemsSource = cridList;
        }

        private void DataGridTeacher_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void RemoveStudentButton_Click(object sender, RoutedEventArgs e)
        {
            var delete = DataGridStudents.SelectedItem as Model.Student;
            if (delete != null)
            {
                Controller.Connect.GetContext().Student.Remove(delete);
                Controller.Connect.GetContext().SaveChanges();
                LoadDataTeacher();
            }
            else
            {
                MessageBox.Show("Вы не выбрали критерий");
            }
        }

        private void RemoveTeacherButton_Click(object sender, RoutedEventArgs e)
        {
            var delete = DataGridTeacher.SelectedItem as Model.Teachers;
            if (delete != null)
            {
                Controller.Connect.GetContext().Teachers.Remove(delete);
                Controller.Connect.GetContext().SaveChanges();
                LoadDataTeacher();
            }
            else
            {
                MessageBox.Show("Вы не выбрали критерий");
            }
        }

        private void RegactorTeacherButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddTeacherButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ListGroup_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
