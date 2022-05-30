using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Логика взаимодействия для EditingAspects.xaml
    /// </summary>
    public partial class EditingAspects : Window
    {
        public Model.Aspect aspect { get; set; }
        public EditingAspects(Model.Aspect AspectCrud)
        {
            InitializeComponent();
            aspect = AspectCrud;
            AspectCriteriaBD();
        }
        public void AspectCriteriaBD()
        {
            var searchCritera = Controller.Connect.GetContext().Aspect.Where(x => x.IdAspect == aspect.IdAspect).FirstOrDefault();
            TitleTextBox.Text = searchCritera.Title;
            NumberOfPointsTextBox.Text = searchCritera.NumberOfPoints.ToString();
            DescriptionTextBox.Text = searchCritera.Description;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if (TitleTextBox.Text == "" || NumberOfPointsTextBox.Text == "") //Проверка на пустые поля                           
            {
                MessageBox.Show("Должен быть указан название аспекта и макс. балл");
                return;
            }
            var criteria = Controller.Connect.GetContext().Aspect;
            foreach (var criter in criteria)
            {
                if (TitleTextBox.Text == criter.Title) //Проверка на идентичность
                {
                    MessageBox.Show("Данный аспект уже существует");
                    return;
                }
            }
            Regex ball = new Regex(@"^(?=.*[0-9])(?=.*[,])\S{4,5}$");  //Проверка на числой формат и цифры после запятой
            if (ball.IsMatch(NumberOfPointsTextBox.Text) == false)
            {
                MessageBox.Show("Макс.балл должен быть от 0 до 99, содержать числовой формат и иметь две цифры после запятой");
                return;
            }
            aspect.Title = TitleTextBox.Text;
            aspect.NumberOfPoints = Convert.ToDouble(NumberOfPointsTextBox.Text);
            aspect.Description = DescriptionTextBox.Text;
            Controller.Connect.GetContext().SaveChanges();
            this.DialogResult = true;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }

        private void RemoveDescriptionlButton_Click(object sender, RoutedEventArgs e)
        {
            blok2.Visibility = Visibility.Hidden;
            DescriptionTextBox.Visibility = Visibility.Hidden;
            RemoveDescriptionlButton.Visibility = Visibility.Hidden;
        }

        private void DescriptionButton_Click(object sender, RoutedEventArgs e)
        {
            if (TitleTextBox.Text == "" || NumberOfPointsTextBox.Text == "")
            {
                MessageBox.Show("Заполните название и баллы");
            }
            else
            {
                blok2.Visibility = Visibility.Visible;
                DescriptionTextBox.Visibility = Visibility.Visible;
                RemoveDescriptionlButton.Visibility = Visibility.Visible;
            }
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
