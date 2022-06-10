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
    /// Логика взаимодействия для AddingAspects.xaml
    /// </summary>
    public partial class AddingAspects : Window
    {
        private Model.SubCriteria _subCriteria { get; set; }
        public AddingAspects(Model.SubCriteria subCriteria)
        {
            InitializeComponent();
            _subCriteria = subCriteria;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            if (TitleTextBox.Text == "" || NumberOfPointsTextBox.Text == "") //Проверка на пустые поля                           
            {
                MessageBox.Show("Должен быть указан название аспекта и макс. балл");
                return;
            }
            var criteria = Controller.Connect.GetContext().Aspect.Where(x => x.IdSubCriteria == _subCriteria.IdSubCriteria && x.Title == TitleTextBox.Text).FirstOrDefault();
            if (criteria != null)
            {
                MessageBox.Show("Такой аспект уже существует");
                return;
            }
            Regex ball = new Regex(@"^(?=.*[0-9])\S{1,4}$");  //Проверка на числой формат и цифры после запятой
            if (ball.IsMatch(NumberOfPointsTextBox.Text) == false)
            {
                MessageBox.Show("Макс. балл должен равняться субкритерию по баллам и содержать числовой формат");
                return;
            }

            if (TitleTextBox.Text.Length > 100)
            {
                MessageBox.Show("Аспект не может содержать больше 100 букв");
                return;
            }

            double maxValue = 0;
            var subCriterias = Controller.Connect.GetContext().Aspect.Where(x => x.IdSubCriteria == _subCriteria.IdSubCriteria).ToList();  //проверка на количество баллов, чтобы не превышал субкритерий
            foreach (var subCriteria in subCriterias)
            {
                maxValue += (double)subCriteria.NumberOfPoints;
            }
            if (maxValue + Convert.ToDouble(NumberOfPointsTextBox.Text) <= _subCriteria.TotalScoresForAllAspects) 
            {
                var sub = new Model.Aspect()
                {
                    Title = TitleTextBox.Text,
                    Description = DescriptionTextBox.Text,
                    NumberOfPoints = Convert.ToDouble(NumberOfPointsTextBox.Text),
                    IdSubCriteria = _subCriteria.IdSubCriteria
                };

                Controller.Connect.GetContext().Aspect.Add(sub);
                Controller.Connect.GetContext().SaveChanges();
                this.DialogResult = true;
            }
            else
            {
                MessageBox.Show("Вы привысили количество баллов над субкритерием");
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e) //закрытие
        {
            this.DialogResult = false;
        }

        private void DescriptionButton_Click(object sender, RoutedEventArgs e) //добавление дополнительного поля
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

        private void RemoveDescriptionlButton_Click(object sender, RoutedEventArgs e) //Скрытие
        {
            blok2.Visibility = Visibility.Hidden;
            DescriptionTextBox.Visibility = Visibility.Hidden;
            RemoveDescriptionlButton.Visibility = Visibility.Hidden;
        }
    }
}