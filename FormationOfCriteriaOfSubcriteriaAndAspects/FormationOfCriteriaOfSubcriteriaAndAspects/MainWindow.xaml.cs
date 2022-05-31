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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FormationOfCriteriaOfSubcriteriaAndAspects
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            var criteriaList = Controller.Connect.GetContext().Criteria.ToList(); //Загрузка Данных
            DataGridCriteria.ItemsSource = criteriaList;
        }

        private void AddCriteriaBut_Click(object sender, RoutedEventArgs e) //переход на окно добавление
        {
            View.AddingCriterion add = new View.AddingCriterion();
            if (add.ShowDialog() == true)
            {
                LoadData();
            }
        }

        private void EditCriteria_Click(object sender, RoutedEventArgs e) //переход на окно редактирования
        {
            View.EditingCriterion add = new View.EditingCriterion(DataGridCriteria.SelectedItem as Model.Criteria);
            if (add.ShowDialog() == true)
            {
                LoadData();
            }
        }

        private void RemoveCriteria_Click(object sender, RoutedEventArgs e) //удаление критериев, субкритериев и аспектов
        {
            var selectedCriteria = DataGridCriteria.SelectedItem as Model.Criteria;
            var subCretirias = Controller.Connect.GetContext().SubCriteria.Where(x => x.IdCriteria == selectedCriteria.IdCriteria);
            foreach (var subCretiria in subCretirias)
            {
                var aspects = Controller.Connect.GetContext().Aspect.Where(x => x.IdSubCriteria == subCretiria.IdSubCriteria);
                {
                    try
                    {
                        Controller.Connect.GetContext().Aspect.RemoveRange(aspects);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
            if (MessageBox.Show("Удалить?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                Controller.Connect.GetContext().SubCriteria.RemoveRange(subCretirias);
                Controller.Connect.GetContext().Criteria.Remove(selectedCriteria);
                Controller.Connect.GetContext().SaveChanges();
                LoadData();
                MessageBox.Show("Данные удалены");
            }
        }

        private void SubCriteriaButton_Click(object sender, RoutedEventArgs e) //переход на страницу субкритерия(подкритерия)
        {
            View.Subcriteria sub = new View.Subcriteria(DataGridCriteria.SelectedItem as Model.Criteria);
            if (sub.ShowDialog() == true)
            {
                LoadData();
            }
        }


        private void TransitionStudent_Click(object sender, RoutedEventArgs e) //переход на окно студенты
        {
            View.StudentsCRUD add = new View.StudentsCRUD(); 
            add.Show();
            this.Close();
        }

        private void TransitionTeacher_Click(object sender, RoutedEventArgs e) //переход на окно преподаватели
        {
            View.TeachersCRUD add = new View.TeachersCRUD();
            add.Show();
            this.Close();
        }
    }
}

