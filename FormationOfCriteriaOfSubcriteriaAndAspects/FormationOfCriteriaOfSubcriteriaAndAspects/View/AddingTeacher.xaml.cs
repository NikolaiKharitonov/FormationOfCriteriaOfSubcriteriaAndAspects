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
    /// Логика взаимодействия для AddingTeacher.xaml
    /// </summary>
    public partial class AddingTeacher : Window
    {
        public AddingTeacher()
        {
            InitializeComponent();
        }

        private void SaveTeachersButton_Click(object sender, RoutedEventArgs e)
        {
            {
                var crit = new Model.Teachers()
                {
                    FirstName = FirstNameTextBox.Text,
                    LastName = LastNameTextBox.Text,
                    Patronymic = PatronymicTextBox.Text,
                    Email = EmailTextBox.Text,
                };
                Controller.Connect.GetContext().Teachers.Add(crit);
                Controller.Connect.GetContext().SaveChanges();
                this.DialogResult = true;
            }
        }

        private void cancellationTeachersButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}
