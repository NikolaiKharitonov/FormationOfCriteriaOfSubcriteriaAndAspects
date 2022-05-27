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
    /// Логика взаимодействия для AddingAspects.xaml
    /// </summary>
    public partial class AddingAspects : Window
    {
        public AddingAspects()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            using (Model.ProductionPracticeEntities db = new Model.ProductionPracticeEntities())
            {
                var add = new Model.Aspect()
                {
                    Title = TitleTextBox.Text,
                    Description = DescriptionTextBox.Text,
                    NumberOfPoints = Convert.ToInt32(NumberOfPointsTextBox.Text)
                };
                try
                {
                    db.Aspect.Add(add);
                    db.SaveChanges();
                    this.DialogResult = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    this.DialogResult = false;
                }
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}
