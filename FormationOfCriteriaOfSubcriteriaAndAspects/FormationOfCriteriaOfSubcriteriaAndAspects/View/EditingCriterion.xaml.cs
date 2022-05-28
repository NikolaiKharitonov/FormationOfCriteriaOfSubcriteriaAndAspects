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
            if (TitleTextBox.Text == "") //Проверка на пустые поля                           
            {
                if (ValueTextBox.Text == "")
                {
                    MessageBox.Show("Должен быть указан Макс. балл");
                    return;
                }
                MessageBox.Show("Должно быть указано имя для критерия");
                return;
            }
            var crit = Controller.Connect.GetContext().Criteria;
            foreach (var criter in crit)
            {
                if (TitleTextBox.Text == criter.Title) //Проверка на идентичность
                {
                    MessageBox.Show("Данный критерий уже существует");
                    return;
                }
            }
            criteria.Title = TitleTextBox.Text;
            criteria.MaxValue = Convert.ToDouble(ValueTextBox.Text);
            Controller.Connect.GetContext().SaveChanges();
            this.DialogResult = true; 
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}
