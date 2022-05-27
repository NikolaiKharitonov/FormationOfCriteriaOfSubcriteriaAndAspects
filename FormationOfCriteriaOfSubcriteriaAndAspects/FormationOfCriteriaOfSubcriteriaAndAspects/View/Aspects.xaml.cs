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
    /// Логика взаимодействия для Aspects.xaml
    /// </summary>
    public partial class Aspects : Window
    {
        public Model.SubCriteria criteria { get; set; }
        public Aspects(Model.SubCriteria crid)
        {
            InitializeComponent();
            criteria = crid;
            LoadDataAspect();
            
        }
        public void LoadDataAspect()
        {
            var criteriaList = Controller.Connect.GetContext().Aspect.Where(x => x.IdSubCriteria == criteria.IdSubCriteria).ToList();
            DataGridAspects.ItemsSource = criteriaList;
        }

        private void AddCriteriaBut_Click(object sender, RoutedEventArgs e)
        {
            View.AddingAspects add = new View.AddingAspects();
            if (add.ShowDialog() == true)
            {
                LoadDataAspect();
            }
        }

        private void EditCriteria_Click(object sender, RoutedEventArgs e)
        {
            View.EditingAspects add = new View.EditingAspects(DataGridAspects.SelectedItem as Model.Aspect);
            if (add.ShowDialog() == true)
            {
                LoadDataAspect();
            }
        }

        private void RemoveCriteria_Click(object sender, RoutedEventArgs e)
        {
            var delete = DataGridAspects.SelectedItem as Model.Aspect;
            if (delete != null)
            {
                Controller.Connect.GetContext().Aspect.Remove(delete);
                Controller.Connect.GetContext().SaveChanges();
                LoadDataAspect();
            }
            else
            {
                MessageBox.Show("Вы не выбрали критерий");
            }
        }
    }
}
