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
    /// Логика взаимодействия для AddingSubcriteria.xaml
    /// </summary>
    public partial class AddingSubcriteria : Window
    {
        public AddingSubcriteria()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            using (Model.ProductionPracticeEntities db = new Model.ProductionPracticeEntities())
            {
                var sub = new Model.SubCriteria()
                {
                    Title = TitleTextBox.Text,
                    TotalScoresForAllAspects = Convert.ToInt32(TotalScoresForAllAspectsTextBox.Text)
                };
                db.SubCriteria.Add(sub);
                db.SaveChanges();

                var asp = new Model.Aspect()
                {
                    IdSubCriteria = sub.IdSubCriteria
                };
                db.Aspect.Add(asp);
                db.SaveChanges();
                MessageBox.Show("Субкритерий добавлен");
                this.DialogResult = true;
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}
