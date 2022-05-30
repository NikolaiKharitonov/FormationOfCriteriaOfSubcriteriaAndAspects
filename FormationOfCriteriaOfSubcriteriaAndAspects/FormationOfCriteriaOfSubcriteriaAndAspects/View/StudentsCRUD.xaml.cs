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
    /// Логика взаимодействия для StudentsCRUD.xaml
    /// </summary>
    public partial class StudentsCRUD : Window
    {
        public StudentsCRUD()
        {
            InitializeComponent();

   //         var tests = Controller.Connect.GetContext().Group.ToList();
   //         foreach (var test in tests)
   //         {
   //            ComboBoxGroup.Items.Add(test.Title);
  //          }
            LoadDataStudent();
        }

        private void RemoveStudentButton_Click(object sender, RoutedEventArgs e)
        {
        var delete = DataGridStudents.SelectedItem as Model.Student;
           if(MessageBox.Show("Удалить?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    Controller.Connect.GetContext().Student.Remove(delete);
                    Controller.Connect.GetContext().SaveChanges();
                    LoadDataStudent();
                    MessageBox.Show("Данные удалены");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }   
            }       
        }
        public void LoadDataStudent()
        {
            var criteriaList = Controller.Connect.GetContext().Student.ToList();
            DataGridStudents.ItemsSource = criteriaList;
        }

        private void ComboBoxGroup_SelectionChanged(object sender, SelectionChangedEventArgs e) //НЕ РАБОТАЕТ
        {
 /*           var group = Controller.Connect.GetContext().Group.ToList();
            if (ComboBoxGroup.SelectedIndex > 0)
            {
                var sort = ComboBoxGroup.SelectedItem as Model.Group;
                if (sort != null)
                    group = group.Where(x => x.IdGroup == sort.IdGroup).ToList();
            }
           DataGridStudents.ItemsSource = group;
 */        }

        private void ComboBoxStatusStudent_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void AddStudent_Click(object sender, RoutedEventArgs e)
        {
            View.AddingStudents save = new View.AddingStudents();
            if (save.ShowDialog() == true)
            {
                LoadDataStudent();
            }
        }

        private void NazadStudent_Click(object sender, RoutedEventArgs e)
        {
            MainWindow add = new MainWindow();
            add.Show();
            this.Close();
        }

        private void RegactorStudentButton_Click(object sender, RoutedEventArgs e)
        {
            View.EditingStudents save = new View.EditingStudents(DataGridStudents.SelectedItem as Model.Student);
            if (save.ShowDialog() == true)
            {
                LoadDataStudent();
            }
        }

        private void DataGridStudents_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
