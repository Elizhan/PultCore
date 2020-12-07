using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PultCore
{
    /// <summary>
    /// Логика взаимодействия для Identification.xaml
    /// </summary>
    public partial class Identification : Window
    {
        public Identification()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void TextBox_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (Login.Text == "Логин")
            {
                Login.Text = "";
            }
        }

        private void Login_LostFocus(object sender, RoutedEventArgs e)
        {
            if (Login.Text == "")
            {
                Login.Text = "Логин";
            }
        }

        private void Password_LostFocus(object sender, RoutedEventArgs e)
        {
            if (Password.Text == "")
            {
                Password.Text = "Пароль";
            }
        }

        private void Password_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (Password.Text == "Пароль")
            {
                Password.Text = "";
            }
        }
    }
}
