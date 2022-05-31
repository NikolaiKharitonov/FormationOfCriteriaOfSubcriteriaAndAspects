﻿using System;
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
                if(EmailTextBox.Text.Length > 30)
                {
                    MessageBox.Show("Email не должен содержать больше 30 букв");
                    return;
                }


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
