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
    /// Логика взаимодействия для EditingCriteria.xaml
    /// </summary>
    public partial class EditingCriteria : Window
    {
        public EditingCriteria()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder error = new StringBuilder();
            if (textBox.Text == "")
            {
                error.AppendLine("Вы не правильный критерий");
            }
            if (textBox1.Text == "")
            {
                error.AppendLine("Вы не правильный Субкритерий");
            }
            if (textBox2.Text == "")
            {
                error.AppendLine("Вы не правильный аспект");
            }
  //          if (textBox3.IsMatch(textBox3.Text) == false)
            {
                error.AppendLine("");
            }
 //           if (textBox4.IsMatch(textBox4.Text) == false)
            {
                error.AppendLine("");
            }
            if (error.Length > 0)
            {
                MessageBox.Show(error.ToString());
                return;
            }
            else
            {
                try
                {
 //                   _connect.GetContext().SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {

 //                  PanelControl _panelControl = new PanelControl(_user);
 //                   _panelControl.Show();
                    MessageBox.Show("Информация сохранена");
                    this.Close();
                }
            }
        }
    }
}
