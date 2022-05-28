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
    /// Логика взаимодействия для AddingCriterion.xaml
    /// </summary>
    public partial class AddingCriterion : Window
    {
        public AddingCriterion()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            bool validComplete = true;
            if (TitleTextBox.Text == "") //Проверка на пустые поля                           
            {
                if (ValueTextBox.Text == "")
                {
                    MessageBox.Show("Должно быть указано имя для критерия");
                    return;
                }
                MessageBox.Show("Должен быть указан Макс. балл");
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
            if (validComplete)
            {
                var crit = new Model.Criteria()
                {
                    Title = TitleTextBox.Text,
                    MaxValue = Convert.ToDouble(ValueTextBox.Text)
                };
                Controller.Connect.GetContext().Criteria.Add(crit);
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
