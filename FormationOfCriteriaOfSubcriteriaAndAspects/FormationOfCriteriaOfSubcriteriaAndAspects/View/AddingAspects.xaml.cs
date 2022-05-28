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
        private Model.SubCriteria _subCriteria { get; set; }
        public AddingAspects(Model.SubCriteria subCriteria)
        {
            InitializeComponent();
            _subCriteria = subCriteria;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            if (TitleTextBox.Text == "") //Проверка на пустые поля                           
            {
                if (DescriptionTextBox.Text == "")
                {
                    MessageBox.Show("Должен быть указан Макс. балл");
                    return;
                }
                MessageBox.Show("Должно быть указано имя для критерия");
                return;
            }
            var criteria = Controller.Connect.GetContext().Aspect;
            foreach (var criter in criteria)
            {
                if (TitleTextBox.Text == criter.Title) //Проверка на идентичность
                {
                    MessageBox.Show("Данный критерий уже существует");
                    return;
                }
            }

            var add = new Model.Aspect()
            {
                Title = TitleTextBox.Text,
                Description = DescriptionTextBox.Text,
                NumberOfPoints = Convert.ToDouble(NumberOfPointsTextBox.Text),
                IdSubCriteria = _subCriteria.IdSubCriteria
            };
            Controller.Connect.GetContext().Aspect.Add(add);
            Controller.Connect.GetContext().SaveChanges();
            MessageBox.Show("Данные сохранены");
            this.DialogResult = true;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
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

        private void RemoveDescriptionlButton_Click(object sender, RoutedEventArgs e)
        {
            blok2.Visibility = Visibility.Hidden;
            DescriptionTextBox.Visibility = Visibility.Hidden;
            RemoveDescriptionlButton.Visibility = Visibility.Hidden;
        }
    }
}