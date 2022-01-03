using System;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using Microsoft.Data.SqlClient;

namespace ProjetForma.Interfaces
{
    public partial class AddUserBox : Window
    {
        string[] defaultPassword = new []{"wearehere", "defaultpassword", "syracuse", "iwillbechanged"};
        private Random rnd = new Random();
        public AddUserBox()
        {
            InitializeComponent();
        }

        private void MsgBox_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
        
        private void NameBox_OnGotFocus(object sender, RoutedEventArgs e)
        {
            NameBox.Text = String.Empty;
            NameBox.Foreground = Brushes.Black;
            NameBox.Opacity = 1;
        }

        private void IsAdminBox_OnClick(object sender, RoutedEventArgs e)
        {
            IsAdminBox.Foreground = Brushes.LimeGreen;

            if (IsAdminBox.IsChecked == false)
            {
                IsAdminBox.Foreground = Brushes.OrangeRed;
            }
        }

        private void AddButton_OnMouseEnter(object sender, MouseEventArgs e)
        {
            AddButton.Background = Brushes.LimeGreen;
            AddButton.Foreground = Brushes.White;
            AddButton.Opacity = 1;
        }
        
        private void AddButton_OnMouseLeave(object sender, MouseEventArgs e)
        {
            AddButton.Background = Brushes.Transparent;
        }

        private void DeleteButton_OnMouseEnter(object sender, MouseEventArgs e)
        {
            DeleteButton.Background = Brushes.DarkRed;
            DeleteButton.Foreground = Brushes.White;
            DeleteButton.Opacity = 1;
        }

        private void DeleteButton_OnMouseLeave(object sender, MouseEventArgs e)
        {
            DeleteButton.Background = Brushes.Transparent;
        }

        private void DeleteButton_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void AddButton_OnClick(object sender, RoutedEventArgs e)
        {
            
        }
    }
}