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
    /// Логика взаимодействия для TeachersCRUD.xaml
    /// </summary>
    public partial class TeachersCRUD : Window
    {
        public TeachersCRUD()
        {
            InitializeComponent();
            LoadDataTeachers();
        }
        public void LoadDataTeachers() //Загрузка Данных
        {
            var criteriaList = Controller.Connect.GetContext().Teachers.ToList();
            DataGridTeacher.ItemsSource = criteriaList;
        }
        private void RemoveTeacherButton_Click(object sender, RoutedEventArgs e) //Удаление
        {
            var delete = DataGridTeacher.SelectedItem as Model.Teachers;
            if (MessageBox.Show("Удалить?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    Controller.Connect.GetContext().Teachers.Remove(delete);
                    Controller.Connect.GetContext().SaveChanges();
                    LoadDataTeachers();
                    MessageBox.Show("Данные удалены");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
        private void NazadTeachersButton_Click(object sender, RoutedEventArgs e) //Кнопка назад
        {
            MainWindow add = new MainWindow();
            add.Show();
            this.Close();
        }
        private void AddTeachersButton_Click(object sender, RoutedEventArgs e) //Переход на добавление преподавателей
        {
            View.AddingTeacher save = new View.AddingTeacher();
            if (save.ShowDialog() == true)
            {
                LoadDataTeachers();
            }
        }
        private void RegactorStudentButton_Click(object sender, RoutedEventArgs e) //Переход на редактирование преподавателей
        {
            View.EditingTeacher save = new View.EditingTeacher(DataGridTeacher.SelectedItem as Model.Teachers);
            if (save.ShowDialog() == true)
            {
                LoadDataTeachers();
            }
        }
    }
}
