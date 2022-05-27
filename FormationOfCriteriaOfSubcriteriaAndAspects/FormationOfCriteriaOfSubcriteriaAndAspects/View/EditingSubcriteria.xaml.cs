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
    /// Логика взаимодействия для EditingSubcriteria.xaml
    /// </summary>
    public partial class EditingSubcriteria : Window
    {
        public Model.SubCriteria subcriteria { get; set; }
        public EditingSubcriteria(Model.SubCriteria crud)
        {
            InitializeComponent();
            subcriteria = crud;
            CriteriaBD();
        }
        public void CriteriaBD()
        {
            var searchCritera = Controller.Connect.GetContext().SubCriteria.Where(x => x.IdSubCriteria == subcriteria.IdSubCriteria).FirstOrDefault();
            TitleTextBox.Text = searchCritera.Title;
            TotalScoresForAllAspectsTextBox.Text = searchCritera.TotalScoresForAllAspects.ToString();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            subcriteria.Title = TitleTextBox.Text;
            subcriteria.TotalScoresForAllAspects = Convert.ToDouble(TotalScoresForAllAspectsTextBox.Text);
            Controller.Connect.GetContext().SaveChanges();
            this.DialogResult = true;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}
