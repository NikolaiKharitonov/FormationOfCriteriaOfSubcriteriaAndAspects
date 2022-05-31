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
    /// Логика взаимодействия для AddingSubcriteria.xaml
    /// </summary>
    public partial class AddingSubcriteria : Window
    {
        private Model.Criteria _criteria { get; set; }
        public AddingSubcriteria(Model.Criteria criteria)
        {
            InitializeComponent();
            _criteria = criteria;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            if (TitleTextBox.Text == "" || TotalScoresForAllAspectsTextBox.Text == "") //Проверка на пустые поля                           
            {
                MessageBox.Show("Должен быть указан название подкритерия и макс. балл");
                return;
            }
            var criteria = Controller.Connect.GetContext().SubCriteria.Where(x => x.IdCriteria == _criteria.IdCriteria && x.Title == TitleTextBox.Text).FirstOrDefault();
            if(criteria != null)
            {
                MessageBox.Show("Такой субкритерий уже существует");
                return;
            }
            Regex ball = new Regex(@"^(?=.*[0-9])\S{1,4}$");  //Проверка на числой формат и цифры после запятой
            if (ball.IsMatch(TotalScoresForAllAspectsTextBox.Text) == false)
            {
                MessageBox.Show("Макс. балл должен равняться критерию по баллам и содержать числовой формат");
                return;
            }

            if (TitleTextBox.Text.Length > 100)
            {
                MessageBox.Show("Субкритерий не может содержать больше 100 букв");
                return;
            }

            double maxValue = 0;
            var subCriterias = Controller.Connect.GetContext().SubCriteria.Where(x => x.IdCriteria == _criteria.IdCriteria).ToList();  //проверка на количество баллов, чтобы не превышали критерий
            foreach (var subCriteria in subCriterias)
            {
                maxValue += (double)subCriteria.TotalScoresForAllAspects;
            }
            if(maxValue + Convert.ToDouble(TotalScoresForAllAspectsTextBox.Text) < _criteria.MaxValue) 
            {
                var sub = new Model.SubCriteria()
                {
                    Title = TitleTextBox.Text,
                    TotalScoresForAllAspects = Convert.ToDouble(TotalScoresForAllAspectsTextBox.Text),
                    IdCriteria = _criteria.IdCriteria
                };

                Controller.Connect.GetContext().SubCriteria.Add(sub);
                Controller.Connect.GetContext().SaveChanges();
                this.DialogResult = true;
            }
            else
            {
                MessageBox.Show("Вы привысили количество баллов над критерием");
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }

        private void TotalScoresForAllAspectsTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
