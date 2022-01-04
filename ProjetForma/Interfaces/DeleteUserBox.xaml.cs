using System;
using System.Windows;
using System.Windows.Input;
using Microsoft.Data.SqlClient;

namespace ProjetForma.Interfaces
{
    public partial class DeleteUserBox : Window
    {
        public DeleteUserBox()
        {
            InitializeComponent();
        }

        private void DeleteButton_OnClick(object sender, RoutedEventArgs e)
        {
            int pidTmp = Convert.ToInt32(PidBox.Text);
            SqlConnection conn = new SqlConnection(Database.DataContext.ConnexionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM [project].[dbo].[partner] WHERE pid=@pid";
            cmd.Parameters.AddWithValue("@pid", pidTmp);
            cmd.Connection = conn;
            var reader = cmd.ExecuteReader();
            cmd.Dispose();
            conn.Close();
            Close();
        }
        
        private void CancelButton_OnClick(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            Close();
            window.Show();
        }

        #region Window Properties

        private void PIDBox_OnGotFocus(object sender, RoutedEventArgs e)
        {
        
        }

        private void DeleteButton_OnMouseEnter(object sender, MouseEventArgs e)
        {
        
        }

        private void DeleteButton_OnMouseLeave(object sender, MouseEventArgs e)
        {
        
        }

        private void DeleteUserBox_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void CancelButton_OnMouseEnter(object sender, MouseEventArgs e)
        {
        
        }

        private void CancelButton_OnMouseLeave(object sender, MouseEventArgs e)
        {
        
        }

        #endregion
    }
}