﻿using System;
using System.CodeDom;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_1(object sender, RoutedEventArgs e)
        {
            MainPage.Content = new Page1();
        }

        private void btn_2(object sender, RoutedEventArgs e)
        {
            MainPage.Content = new Page2();
        }

        private void btn_3(object sender, RoutedEventArgs e)
        {
            MainPage.Content = new Page3();
        }
    }
}
