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
            GroupStudentComboBox.ItemsSource = Controller.Connect.GetContext().Group.ToList();
        }

        private void AddStudents_Click(object sender, RoutedEventArgs e)
        {
            {
                if (FirstNameTextBox.Text == "" || LastNameTextBox.Text == "" || PatronymicTextBox.Text == "") //Проверка на пустые поля                           
                {
                    MessageBox.Show("Укажите фамилию, имя и отчество");
                    return;
                }
                if (FirstNameTextBox.Text.Length > 30 || LastNameTextBox.Text.Length > 30 || PatronymicTextBox.Text.Length > 30) //Проверка на количество вводимых значений до 30
                {
                    MessageBox.Show("Фамилия, имя и отчество не должны содержать больше 30 букв");
                    return;
                }
                if (EmailTextBox.Text.Length > 30)
                {
                    MessageBox.Show("Email не должен содержать больше 30 букв");
                    return;
                }
                Regex ball = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");  //Проверка email
                if (ball.IsMatch(EmailTextBox.Text) == false)
                {
                    MessageBox.Show("Нужен Email адрес");
                    return;
                }
                Regex tel = new Regex(@"^(?=.*[0-9])\S{11,11}$");  //Проверка номера телефона
                if (tel.IsMatch(TelephoneTextBox.Text) == false)
                {
                    MessageBox.Show("Номер должен содержать 11 цифр и числовой формат");
                    return;
                }


                var crit = new Model.Student()
                {
                    FirstName = FirstNameTextBox.Text,
                    LastName = LastNameTextBox.Text,
                    Patronymic = PatronymicTextBox.Text,
                    Email = EmailTextBox.Text,
                    Telephone = TelephoneTextBox.Text,
                    IdGroup = (GroupStudentComboBox.SelectedItem as Model.Group).IdGroup
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
