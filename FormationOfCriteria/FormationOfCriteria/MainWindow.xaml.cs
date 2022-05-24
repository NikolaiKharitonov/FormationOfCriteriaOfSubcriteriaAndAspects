using FormationOfCriteria.View;
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

namespace FormationOfCriteria
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Model.ProductionPracticeEntities3 dbCon = Controller.Connect.GetContext();
 //           dataGrid.ItemsSource = dbCon.Aspect.ToList();

        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            View.AddingCriteria add = new View.AddingCriteria();
            add.Show();
        }



        private void ButtonSaveKriteria_Click(object sender, RoutedEventArgs e)
        {
            AddA.Visibility = Visibility.Visible;
            RemoveA.Visibility = Visibility.Visible;

            AddB.Visibility = Visibility.Visible;
            RemoveB.Visibility = Visibility.Visible;

            AddC.Visibility = Visibility.Visible;
            RemoveC.Visibility = Visibility.Visible;

            AddD.Visibility = Visibility.Visible;
            RemoveD.Visibility = Visibility.Visible;

            AddE.Visibility = Visibility.Visible;
            RemoveE.Visibility = Visibility.Visible;

            AddF.Visibility = Visibility.Visible;
            RemoveF.Visibility = Visibility.Visible;
        }

        private void AddA_Click(object sender, RoutedEventArgs e)
        {
            View.AddingCriteria add = new View.AddingCriteria();
            add.Show();
        }

        private void AddB_Click(object sender, RoutedEventArgs e)
        {
            View.AddingCriteria add = new View.AddingCriteria();
            add.Show();
        }
    }
}
