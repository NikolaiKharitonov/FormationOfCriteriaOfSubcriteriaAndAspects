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
    /// Логика взаимодействия для Subcriteria.xaml
    /// </summary>
    public partial class Subcriteria : Window
    {

        public Model.Criteria criteria { get; set; }

        public Subcriteria(Model.Criteria crud)
        {
            InitializeComponent();
            criteria = crud;
            SubtitleLabel.Text = crud.Title;
            LoadDataSubCriteria();
        }


        public void LoadDataSubCriteria()
        {
            var criteriaList = Controller.Connect.GetContext().SubCriteria.Where(x => x.IdCriteria == criteria.IdCriteria).ToList();
            DataGridSubCriteria.ItemsSource = criteriaList;
        }

        private void AspectButton_Click(object sender, RoutedEventArgs e)
        {
            View.Aspects add = new View.Aspects(DataGridSubCriteria.SelectedItem as Model.SubCriteria);
            if (add.ShowDialog() == true)
            {
                this.Close();
                LoadDataSubCriteria();
            }
        }

        private void AddCriteriaBut_Click(object sender, RoutedEventArgs e)
        {
            View.AddingSubcriteria add = new View.AddingSubcriteria(criteria);
            if (add.ShowDialog() == true)
            {
                LoadDataSubCriteria();
            }
        }

        private void EditCriteria_Click(object sender, RoutedEventArgs e)
        {
            View.EditingSubcriteria add = new View.EditingSubcriteria(DataGridSubCriteria.SelectedItem as Model.SubCriteria);
            if (add.ShowDialog() == true)
            {
                LoadDataSubCriteria();
            }
        }
        private void RemoveCriteria_Click(object sender, RoutedEventArgs e)
        {
            var selectedSap = DataGridSubCriteria.SelectedItem as Model.SubCriteria;
            var aspects = Controller.Connect.GetContext().Aspect.Where(x => x.IdSubCriteria == selectedSap.IdSubCriteria).ToList();
            if (MessageBox.Show("Удалить?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    Controller.Connect.GetContext().Aspect.RemoveRange(aspects);
                    Controller.Connect.GetContext().SubCriteria.Remove(selectedSap);
                    Controller.Connect.GetContext().SaveChanges();
                    LoadDataSubCriteria();
                    MessageBox.Show("Данные удалены");
                }
                catch (Exception ex)

                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
    }
}
