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

        public void LoadDataEditingTeachers()
        {
            var searchCritera = Controller.Connect.GetContext().Teachers.Where(x => x.IdTeachers == criteria.IdTeachers).FirstOrDefault();
            FirstNameTextBox.Text = searchCritera.FirstName;
            LastNameTextBox.Text = searchCritera.LastName;
            PatronymicTextBox.Text = searchCritera.Patronymic;
            EmailTextBox.Text = searchCritera.Email;
        }

        private void SaveTeachersButton_Click(object sender, RoutedEventArgs e)
        {
            criteria.FirstName = FirstNameTextBox.Text;
            criteria.LastName = LastNameTextBox.Text;
            criteria.Patronymic = PatronymicTextBox.Text;
            criteria.Email = EmailTextBox.Text;
            Controller.Connect.GetContext().SaveChanges();
            this.DialogResult = true;
        }

        private void cancellationTeachersButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}
