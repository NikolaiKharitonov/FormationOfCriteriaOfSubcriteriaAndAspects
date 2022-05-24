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
    /// Логика взаимодействия для AddingAspect.xaml
    /// </summary>
    public partial class AddingAspect : Window
    {
        public AddingAspect()
        {
            InitializeComponent();
        }

        private void TextBoxNameTextA_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void AddPlus_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxNameTextA.Text == "" || TextBoxNameTextA.Text == "")
            {
                MessageBox.Show("Заполните описание и баллы");
            }
            else
            {
                blok2.Visibility = Visibility.Visible;
                TextBoxNameTextB.Visibility = Visibility.Visible;
                TextB.Visibility = Visibility.Visible;
                TextBoxMaxBallB.Visibility = Visibility.Visible;
                AddPlusА2.Visibility = Visibility.Visible;
                RemoveAspectaA2.Visibility = Visibility.Visible;
            }
        }

        private void AddPlusА2_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxNameTextB.Text == "" || TextBoxNameTextB.Text == "")
            {
                MessageBox.Show("Заполните описание и баллы");
            }
            else
            {
                blok3.Visibility = Visibility.Visible;
                TextBoxNameTextC.Visibility = Visibility.Visible;
                TextC.Visibility = Visibility.Visible;
                TextBoxMaxBallC.Visibility = Visibility.Visible;
                AddPlusА3.Visibility = Visibility.Visible;
                RemoveAspectaA3.Visibility = Visibility.Visible;
            }
        }

        private void AddPlusА3_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxNameTextC.Text == "" || TextBoxNameTextC.Text == "")
            {
                MessageBox.Show("Заполните описание и баллы");
            }
            else
            {
                blok4.Visibility = Visibility.Visible;
                TextBoxNameTextD.Visibility = Visibility.Visible;
                TextD.Visibility = Visibility.Visible;
                TextBoxMaxBallD.Visibility = Visibility.Visible;
                AddPlusА4.Visibility = Visibility.Visible;
                RemoveAspectaA4.Visibility = Visibility.Visible;
            }
        }

        private void AddPlusА4_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxNameTextD.Text == "" || TextBoxNameTextD.Text == "")
            {
                MessageBox.Show("Заполните описание и баллы");
            }
            else
            {
                blok5.Visibility = Visibility.Visible;
                TextBoxNameTextE.Visibility = Visibility.Visible;
                TextE.Visibility = Visibility.Visible;
                TextBoxMaxBallE.Visibility = Visibility.Visible;
                AddPlusА5.Visibility = Visibility.Visible;
                RemoveAspectaA5.Visibility = Visibility.Visible;
            }
        }

        private void AddPlusА5_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxNameTextE.Text == "" || TextBoxNameTextD.Text == "")
            {
                MessageBox.Show("Заполните описание и баллы");
            }
            else
            {
                blok6.Visibility = Visibility.Visible;
                TextBoxNameTextF.Visibility = Visibility.Visible;
                TextF.Visibility = Visibility.Visible;
                TextBoxMaxBallF.Visibility = Visibility.Visible;
                AddPlusА6.Visibility = Visibility.Visible;
                RemoveAspectaA6.Visibility = Visibility.Visible;
            }
        }

        private void AddPlusА6_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxNameTextF.Text == "" || TextBoxNameTextD.Text == "")
            {
                MessageBox.Show("Заполните описание и баллы");
            }
            else
            {
                blok7.Visibility = Visibility.Visible;
                TextBoxNameTextG.Visibility = Visibility.Visible;
                TextG.Visibility = Visibility.Visible;
                TextBoxMaxBallG.Visibility = Visibility.Visible;
                AddPlusА7.Visibility = Visibility.Visible;
                RemoveAspectaA7.Visibility = Visibility.Visible;
            }
        }

        private void AddPlusА7_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
