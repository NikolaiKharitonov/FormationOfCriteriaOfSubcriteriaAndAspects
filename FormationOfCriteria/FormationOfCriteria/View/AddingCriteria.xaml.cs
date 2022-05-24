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

namespace FormationOfCriteria.View
{
    /// <summary>
    /// Логика взаимодействия для AddingCriteria.xaml
    /// </summary>
    public partial class AddingCriteria : Window
    {
        public AddingCriteria()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            /*   f(Connect.GetContext().Tests.Any(a => a.Name_Test == TBTest.Text) == true)
                   {
                   MessageBox.Show("Такой критерий уже существует");
               }
                   else
               {
                   try
                   {
                       _tests.Name_Test = TBTest.Text;
                       _tests.Time_On_Test = Convert.ToInt32(TbTimeOnTest.Text);
                       Connect.GetContext().Tests.Add(_tests);
                       questionList = null;
                       Connect.GetContext().SaveChanges();
                       MessageBox.Show("Критерий Добавлен!");
                   }
                   catch (Exception ex)
                   {
                       MessageBox.Show(ex.Message.ToString());
                   }

                   testsList = Connect.GetContext().Tests.ToList();
                   _tests = testsList[testsList.Count - 1];
                   NumberPageTest = testsList.Count;
                   questionList = Connect.GetContext().Questions.Where(a => a.ID_ == _tests.ID_Test).ToList();
                   TBQuestion.Text = "";

                   NumberPageQuestion = 1;
                   TbNumberQuestion.Text = "1";
             }
            */
        }

        private void ButtonSaveKriteria_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddPlus_Click(object sender, RoutedEventArgs e)
        {
            View.AddingAspect add = new View.AddingAspect();
            add.Show();
        }

        private void TextBoxNameTextA1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
