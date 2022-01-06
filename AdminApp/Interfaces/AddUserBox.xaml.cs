using System;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using Microsoft.Data.SqlClient;

namespace AdminApp.Interfaces
{
    public partial class AddUserBox : Window
    {
        #region Attributs

        string[] defaultPassword = new []{"wearehere", "defaultpassword", "syracuse", "iwillbechanged"};
        private Random rnd = new Random();

        #endregion

        public AddUserBox()
        {
            InitializeComponent();
        }

        #region Logique Métier

        private void AddButton_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                string name = NameBox.Text;
                int password = rnd.Next(defaultPassword.Length);
                SqlConnection conn = new SqlConnection(Database.DataContext.ConnexionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "INSERT INTO [project].[dbo].[partner] VALUES (@name, @password, @isAdmin)";
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@password", defaultPassword[password]);
                cmd.Parameters.AddWithValue("@isAdmin", IsAdminBox.IsChecked);
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                conn.Close();
                Close();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }
        
        private void MsgBox_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
        
        private void CancelButton_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        #endregion

        #region Window Properties

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

        private void CancelButton_OnMouseEnter(object sender, MouseEventArgs e)
        {
            CancelButton.Background = Brushes.DarkRed;
            CancelButton.Foreground = Brushes.White;
            CancelButton.Opacity = 1;
        }

        private void CancelButton_OnMouseLeave(object sender, MouseEventArgs e)
        {
            CancelButton.Background = Brushes.Transparent;
        }

        #endregion
    }
}