﻿using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace ProjetForma
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void ButtonCanal_OnMouseEnter(object sender, MouseEventArgs e)
        {
            ButtonCanal.Background = Brushes.Chocolate;
            ButtonCanal.Foreground = Brushes.WhiteSmoke;
            ButtonCanal.Opacity = 1;
        }

        private void ButtonCanal_OnMouseLeave(object sender, MouseEventArgs e)
        {
            ButtonCanal.Background = Brushes.Transparent;
        }

        private void ButtonModerate_OnMouseEnter(object sender, MouseEventArgs e)
        {
            ButtonModerate.Background = Brushes.Chocolate;
            ButtonModerate.Foreground = Brushes.WhiteSmoke;
            ButtonModerate.Opacity = 1;
        }

        private void ButtonModerate_OnMouseLeave(object sender, MouseEventArgs e)
        {
            ButtonModerate.Background = Brushes.Transparent;
        }

        private void ButtonUser_OnMouseEnter(object sender, MouseEventArgs e)
        {
            ButtonUser.Background = Brushes.Chocolate;
            ButtonUser.Foreground = Brushes.WhiteSmoke;
            ButtonUser.Opacity = 1;
        }

        private void ButtonUser_OnMouseLeave(object sender, MouseEventArgs e)
        {
            ButtonUser.Background = Brushes.Transparent;
        }
        
        private void Quit_MouseEnter(object sender, RoutedEventArgs e)
        {
            Quit.Background = Brushes.DarkRed;
            Quit.Foreground = Brushes.White;
            Quit.Opacity = 1;
        }
        private void Quit_MouseLeave(object sender, RoutedEventArgs e)
        {
            Quit.Background = Brushes.Transparent;
        }

        private void Quit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}