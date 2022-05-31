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
    /// Логика взаимодействия для EditingStudents.xaml
    /// </summary>
    public partial class EditingStudents : Window
    {
        public Model.Student criteria { get; set; }
        public EditingStudents(Model.Student crud)
        {
            InitializeComponent();
            criteria = crud;
            GroupStudentComboBox.ItemsSource = Controller.Connect.GetContext().Group.ToList();
            LoadDataEditingStudent();
        }

        public void LoadDataEditingStudent()
        {
            var searchCritera = Controller.Connect.GetContext().Student.Where(x => x.IdStudent == criteria.IdStudent).FirstOrDefault();
            FirstNameTextBox.Text = searchCritera.FirstName;
            LastNameTextBox.Text = searchCritera.LastName;
            PatronymicTextBox.Text = searchCritera.Patronymic;
            EmailTextBox.Text = searchCritera.Email;
            TelephoneTextBox.Text = searchCritera.Telephone;
        }

        private void SaveStudentsButton_Click(object sender, RoutedEventArgs e)
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
            if (TelephoneTextBox.Text.Length > 11)
            {
                MessageBox.Show("Телефон должен содержать 11 цифр");
                return;
            }
            if (TelephoneTextBox.Text.Length < 11)
            {
                MessageBox.Show("Телефон должен содержать 11 цифр");
                return;
            }
            criteria.FirstName = FirstNameTextBox.Text;
            criteria.LastName = LastNameTextBox.Text;
            criteria.Patronymic = PatronymicTextBox.Text;
            criteria.Email = EmailTextBox.Text;
            criteria.Telephone = TelephoneTextBox.Text;
            criteria.IdGroup = (GroupStudentComboBox.SelectedItem as Model.Group).IdGroup;
            Controller.Connect.GetContext().SaveChanges();
            this.DialogResult = true;
        }

        private void cancellationStudentsButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}
