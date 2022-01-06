using System;
using System.Data;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using Microsoft.Data.SqlClient;

namespace AdminApp.Interfaces;

public partial class Moderation : Window
{
    DataTable dtbl = new ("why");
    public Moderation()
    {
        InitializeComponent();
    }

    private void BindDataGrid(object sender, RoutedEventArgs routedEventArgs)
    {
        GetWhyInfos();
    }

    private void GetWhyInfos()
    {
        SqlConnection conn = new SqlConnection(Database.DataContext.ConnexionString);
        conn.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "SELECT * FROM [project].[dbo].[why]";
        cmd.Connection = conn;
        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        adapter.Fill(dtbl);
        adapter.Update(dtbl);
        cmd.Dispose();
        conn.Close();
    }
    
    private void DeleteButton_OnClick(object sender, RoutedEventArgs e)
    {
        
    }

    private void QuitButton_OnClick(object sender, RoutedEventArgs e)
    {
        MainWindow window = new MainWindow();
        Close();
        window.Show();
    }

    #region Window Properties

    private void DeleteButton_OnMouseEnter(object sender, MouseEventArgs e)
    {
        DeleteButton.Background = Brushes.Chocolate;
        DeleteButton.Foreground = Brushes.White;
        DeleteButton.Opacity = 1;
    }

    private void DeleteButton_OnMouseLeave(object sender, MouseEventArgs e)
    {
        DeleteButton.Background = Brushes.Transparent;
    }
    
    private void QuitButton_OnMouseEnter(object sender, MouseEventArgs e)
    {
        QuitButton.Background = Brushes.DarkRed;
        QuitButton.Foreground = Brushes.White;
        QuitButton.Opacity = 1;
    }

    private void QuitButton_OnMouseLeave(object sender, MouseEventArgs e)
    {
        QuitButton.Background = Brushes.Transparent;
    }

    #endregion
}