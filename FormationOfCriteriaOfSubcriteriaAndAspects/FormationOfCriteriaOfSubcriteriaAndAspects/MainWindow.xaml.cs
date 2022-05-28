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
            var criteriaList = Controller.Connect.GetContext().Criteria.ToList();
            DataGridCriteria.ItemsSource = criteriaList;

        }

            private void AddCriteriaBut_Click(object sender, RoutedEventArgs e)
            {
                View.AddingCriterion add = new View.AddingCriterion();
                if (add.ShowDialog() == true)
                {
                    LoadData();
                }
            }

            private void EditCriteria_Click(object sender, RoutedEventArgs e)
            {
                View.EditingCriterion add = new View.EditingCriterion(DataGridCriteria.SelectedItem as Model.Criteria);
                if (add.ShowDialog() == true)
                {
                    LoadData();
                }
            }

            private void RemoveCriteria_Click(object sender, RoutedEventArgs e)
            {
                var selectedCriteria = DataGridCriteria.SelectedItem as Model.Criteria;
                var subCretirias = Controller.Connect.GetContext().SubCriteria.Where(x => x.IdCriteria == selectedCriteria.IdCriteria);
                foreach (var subCretiria in subCretirias)
                {
                    var aspects = Controller.Connect.GetContext().Aspect.Where(x => x.IdSubCriteria == subCretiria.IdSubCriteria);
                    try
                    {
                        Controller.Connect.GetContext().Aspect.RemoveRange(aspects);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                Controller.Connect.GetContext().SubCriteria.RemoveRange(subCretirias);
                Controller.Connect.GetContext().Criteria.Remove(selectedCriteria);
                Controller.Connect.GetContext().SaveChanges();
                LoadData();
            }

            private void SubCriteriaButton_Click(object sender, RoutedEventArgs e)
            {
                View.Subcriteria sub = new View.Subcriteria(DataGridCriteria.SelectedItem as Model.Criteria);
                if (sub.ShowDialog() == true)
                {
                    LoadData();
                }
            }

            private void Transition_Click(object sender, RoutedEventArgs e)
            {
                View.StudentsAndTeachers add = new View.StudentsAndTeachers();
                if (add.ShowDialog() == true)
                {
                    LoadData();
                }
            }
        }
    }

