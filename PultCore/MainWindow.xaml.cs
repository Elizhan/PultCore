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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;

namespace PultCore
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var desctop = System.Windows.SystemParameters.WorkArea;
            this.Left = desctop.Right - (this.Width);
            this.Top = desctop.Bottom - (this.Height);
             
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var desctop = System.Windows.SystemParameters.WorkArea;
            this.Left = desctop.Right - (this.Width - 300);
            this.Top = desctop.Bottom - this.Height;
        }

        private void Grid_MouseLeave(object sender, MouseEventArgs e)
        {
            var desctop = System.Windows.SystemParameters.WorkArea;
            this.Left = desctop.Right - (this.Width - 300);
            this.Top = desctop.Bottom - this.Height;
            BtnShow.Visibility = Visibility.Visible;
        }


        private void BtnShow_MouseEnter(object sender, MouseEventArgs e)
        {
            var desctop = System.Windows.SystemParameters.WorkArea;
            this.Left = desctop.Right - (this.Width);
            this.Top = desctop.Bottom - (this.Height);
            BtnShow.Visibility = Visibility.Hidden;
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            List2.Height = 220;
            List2.Visibility = Visibility.Visible;
            if (List1.Visibility == Visibility.Visible)
            {
                List1.Height = 0;
                List1.Visibility = Visibility.Hidden;
            }
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            List1.Height = 220;
            List1.Visibility = Visibility.Visible;
            if (List2.Visibility == Visibility.Visible)
            {
                List2.Height = 0;
                List2.Visibility = Visibility.Hidden;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            WindowNambe.Text = "Окно №";
            OzidanieBtn.Text = "Ожидаюшие";
            OcheredBtn.Text = "Очередь";
            NextBtnPesr.Tag = "Следуюший";
            Pause.Tag = "Пауза";
            Next.Tag = "Начать Обслуживание";
            Vyzov.Tag = "Вызов";
            Kassa.Tag = "На кассу";
            AndBtn.Tag = "Завершить";
            Otlozhit.Tag = "Отложить";
            Perevod.Tag = "Перенаправить";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            WindowNambe.Text = "Терезе №";
            OzidanieBtn.Text = "Кутуучулор";
            OcheredBtn.Text = "кутудо";
            NextBtnPesr.Tag = "Кийинки";
            Pause.Tag = "Тыным";
            Next.Tag = "Тейлеп Баштоо";
            Vyzov.Tag = "Чакыруу";
            Kassa.Tag = "Кассага";
            AndBtn.Tag = "Бутуруу";
            Otlozhit.Tag = "Кутууго койуу";
            Perevod.Tag = "Которуу";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            WindowNambe.Text = "Window №";
            WindowNambe.FontSize = 17;
            OzidanieBtn.Text = "Pending";
            OcheredBtn.Text = "Turn";
            NextBtnPesr.Tag = "Following";
            Pause.Tag = "Pause";
            Next.Tag = "Start Service";
            Vyzov.Tag = "Call";
            AndBtn.Tag = "To complete";
            Kassa.Tag = "To the checkout";
            Otlozhit.Tag = "Postpone";
            Perevod.Tag = "Redirect";
        }
    }
}
