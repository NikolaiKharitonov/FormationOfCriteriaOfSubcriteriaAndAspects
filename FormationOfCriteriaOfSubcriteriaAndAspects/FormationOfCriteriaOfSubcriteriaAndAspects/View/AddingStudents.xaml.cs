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
    /// Логика взаимодействия для AddingStudents.xaml
    /// </summary>
    public partial class AddingStudents : Window
    {
        public AddingStudents()
        {
            InitializeComponent();
        }

        private void AddStudents_Click(object sender, RoutedEventArgs e)
        {
            
            {
                var crit = new Model.Student()
                {
                    FirstName = FirstNameTextBox.Text,
                    LastName = LastNameTextBox.Text,
                    Patronymic = PatronymicTextBox.Text,
                    Email = EmailTextBox.Text,
                    Telephone = TelephoneTextBox.Text
                };
                Controller.Connect.GetContext().Student.Add(crit);
                Controller.Connect.GetContext().SaveChanges();
                this.DialogResult = true;
            }
        }

        private void cancellationStudentsButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}
