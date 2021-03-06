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
    /// Логика взаимодействия для EditingTeacher.xaml
    /// </summary>
    public partial class EditingTeacher : Window
    {
        public Model.Teachers criteria { get; set; }
        public EditingTeacher(Model.Teachers crud)
        {
            InitializeComponent();
            criteria = crud;
            LoadDataEditingTeachers();
        }

        public void LoadDataEditingTeachers() //Загрузка Данных
        {
            var searchCritera = Controller.Connect.GetContext().Teachers.Where(x => x.IdTeachers == criteria.IdTeachers).FirstOrDefault();
            FirstNameTextBox.Text = searchCritera.FirstName;
            LastNameTextBox.Text = searchCritera.LastName;
            PatronymicTextBox.Text = searchCritera.Patronymic;
            EmailTextBox.Text = searchCritera.Email;
        }

        private void SaveTeachersButton_Click(object sender, RoutedEventArgs e)
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
            if (EmailTextBox.Text.Length > 30) //Проверка e-mail
            {
                MessageBox.Show("Email не должен содержать больше 30 букв");
                return;
            }
            Regex surname = new Regex(@"^[А-Яа-я]+$"); //Проверка фамилии
            if (surname.IsMatch(FirstNameTextBox.Text) == false)
            {
                MessageBox.Show("Фамилия должна содержать буквы");
                return;
            }
            Regex name = new Regex(@"^[А-Яа-я]+$"); //Проверка имени
            if (name.IsMatch(LastNameTextBox.Text) == false)
            {
                MessageBox.Show("Имя должно содержать буквы");
                return;
            }
            Regex fuo = new Regex(@"^[А-Яа-я]+$"); //Проверка отчества
            if (fuo.IsMatch(PatronymicTextBox.Text) == false)
            {
                MessageBox.Show("Отчество должно содержать буквы");
                return;
            }
            Regex ball = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([com]\w+)*");  //Проверка email
            if (ball.IsMatch(EmailTextBox.Text) == false)
            {
                MessageBox.Show("Нужен Email адрес");
                return;
            }

            criteria.FirstName = FirstNameTextBox.Text;
            criteria.LastName = LastNameTextBox.Text;
            criteria.Patronymic = PatronymicTextBox.Text;
            criteria.Email = EmailTextBox.Text;
            Controller.Connect.GetContext().SaveChanges();
            this.DialogResult = true;
        }

        private void cancellationTeachersButton_Click(object sender, RoutedEventArgs e) //Закрытие
        {
            this.DialogResult = false;
        }
    }
}
