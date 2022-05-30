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
                MessageBox.Show("Укажите ФИО");
                return;
            }
            criteria.FirstName = FirstNameTextBox.Text;
            criteria.LastName = LastNameTextBox.Text;
            criteria.Patronymic = PatronymicTextBox.Text;
            criteria.Email = EmailTextBox.Text;
            criteria.Telephone = TelephoneTextBox.Text;
            Controller.Connect.GetContext().SaveChanges();
            this.DialogResult = true;
        }

        private void cancellationStudentsButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}
