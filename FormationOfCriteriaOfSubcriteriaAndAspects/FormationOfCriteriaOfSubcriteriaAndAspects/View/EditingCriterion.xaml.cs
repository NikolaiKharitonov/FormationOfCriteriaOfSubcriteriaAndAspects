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
    /// Логика взаимодействия для EditingCriterion.xaml
    /// </summary>
    public partial class EditingCriterion : Window
    {
        public Model.Criteria criteria { get; set; }
        public EditingCriterion(Model.Criteria crit)
        {
            InitializeComponent();
            criteria = crit;
            CriteriaBD();
        }
        public void CriteriaBD()
        {
            var searchCritera = Controller.Connect.GetContext().Criteria.Where(x => x.IdCriteria == criteria.IdCriteria).FirstOrDefault();
            TitleTextBox.Text = searchCritera.Title;
            ValueTextBox.Text = searchCritera.MaxValue.ToString();
        }
        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            bool validComplete = true;
            if (TitleTextBox.Text == "" || ValueTextBox.Text == "") //Проверка на пустые поля                           
            {
                MessageBox.Show("Должен быть указан название критерия и макс. балл");
                return;
            }
            var criteria = Controller.Connect.GetContext().Criteria;
            foreach (var criter in criteria)
            {
                if (TitleTextBox.Text == criter.Title) //Проверка на идентичность
                {
                    MessageBox.Show("Данный критерий уже существует");
                    validComplete = false;
                    return;
                }
            }
            Regex ball = new Regex(@"^(?=.*[0-9])(?=.*[,])\S{5,5}$");  //Проверка на числой формат и цифры после запятой
            if (ball.IsMatch(ValueTextBox.Text) == false)
            {
                MessageBox.Show("Макс. балл должен быть от 10 до 99, содержать числовой формат и иметь две цифры после запятой");
                return;
            }
            if (validComplete)
            {
                var crit = new Model.Criteria()
                {
                    Title = TitleTextBox.Text,
                    MaxValue = Convert.ToDouble(ValueTextBox.Text)
                };
                Controller.Connect.GetContext().SaveChanges();
                this.DialogResult = true;
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}
