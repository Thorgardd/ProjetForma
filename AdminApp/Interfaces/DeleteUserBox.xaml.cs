using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using Microsoft.Data.SqlClient;

namespace AdminApp.Interfaces
{
    public partial class DeleteUserBox : Window
    {
        public DeleteUserBox()
        {
            InitializeComponent();
        }

        #region Logique Métier

        /// <summary>
        /// SQL Request for deleting a user from the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteButton_OnClick(object sender, RoutedEventArgs e)
        {
            int pidTmp = Convert.ToInt32(PidBox.Text);
            SqlConnection conn = new SqlConnection(Database.DataContext.ConnexionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM [TYP_ERROR].[dbo].[partner] WHERE pid=@pid";
            cmd.Parameters.AddWithValue("@pid", pidTmp);
            cmd.Connection = conn;
            var reader = cmd.ExecuteReader();
            cmd.Dispose();
            conn.Close();
            Close();
        }
        
        /// <summary>
        /// Click event for Cancel Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_OnClick(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            Close();
            window.Show();
        }

        #endregion

        #region Window Properties

        private void PIDBox_OnGotFocus(object sender, RoutedEventArgs e)
        {
            PidBox.Text = String.Empty;
            PidBox.Foreground = Brushes.Black;
            PidBox.Opacity = 1;
        }

        private void DeleteButton_OnMouseEnter(object sender, MouseEventArgs e)
        {
            DeleteButton.Background = Brushes.LimeGreen;
            DeleteButton.Foreground = Brushes.White;
            DeleteButton.Opacity = 1;
        }

        private void DeleteButton_OnMouseLeave(object sender, MouseEventArgs e)
        {
            DeleteButton.Background = Brushes.Transparent;
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
        
        private void DeleteUserBox_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        #endregion
    }
}