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
        public Model.Aspect _aspect { get; set; }
        public EditingAspects(Model.Aspect AspectCrud)
        {
            InitializeComponent();
            _aspect = AspectCrud;
            AspectCriteriaBD();
        }
        public void AspectCriteriaBD() //Загрузка Данных
        {
            var searchCritera = Controller.Connect.GetContext().Aspect.Where(x => x.IdAspect == _aspect.IdAspect).FirstOrDefault();
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
            var criteria = Controller.Connect.GetContext().Aspect.Where(x => x.IdSubCriteria == _aspect.IdSubCriteria && x.Title == TitleTextBox.Text).FirstOrDefault();
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
            if (TitleTextBox.Text.Length > 100) //Проверка аспекта
            {
                MessageBox.Show("Аспект не может содержать больше 100 букв");
                return;
            }
            if (DescriptionTextBox.Text.Length > 100) //Проверка дополнительно описания
            {
                MessageBox.Show("Дополнительное описание не может содержать больше 100 букв");
                return;
            }

            _aspect.Title = TitleTextBox.Text;
                _aspect.NumberOfPoints = Convert.ToDouble(NumberOfPointsTextBox.Text);
                _aspect.Description = DescriptionTextBox.Text;
                Controller.Connect.GetContext().SaveChanges();
                this.DialogResult = true;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e) //закрытие
        {
            this.DialogResult = false;
        }

        private void RemoveDescriptionlButton_Click(object sender, RoutedEventArgs e) //скрытие
        {
            blok2.Visibility = Visibility.Hidden;
            DescriptionTextBox.Visibility = Visibility.Hidden;
            RemoveDescriptionlButton.Visibility = Visibility.Hidden;
        }

        private void DescriptionButton_Click(object sender, RoutedEventArgs e) //Открытие дополнительного описания, если все поля заполнены
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
    }
}
