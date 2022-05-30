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
                if (FirstNameTextBox.Text == "" || LastNameTextBox.Text == "" || PatronymicTextBox.Text == "") //Проверка на пустые поля                           
                {
                    MessageBox.Show("Укажите ФИО");
                    return;
                }
                Regex LoginRegex = new Regex(@"^(([A-Z]+)||([a-z]+)(([0-9]*[a-z]*[A-Z]*)*[_,-]*)+){6,30}$");
                if (LoginRegex.IsMatch(EmailTextBox.Text) == false)
                {
                    try
                    {
                        MessageBox.Show("должен содержать большую букву, хотя бы одну цифру,\nодин знак, иметь длину больше 6 символов");
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                }
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
