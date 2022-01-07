using System;
using System.Data;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace AdminApp.Interfaces;

public partial class Moderation : Window
{
    public Moderation()
    {
        InitializeComponent();
    }

    #region Logique métier

    private void BindDataGrid(object sender, RoutedEventArgs routedEventArgs)
    {
        GetHelpInfos();
    }

    private void GetHelpInfos()
    {
        DataTable dtbl = new ("help");
        SqlConnection conn = new SqlConnection(Database.DataContext.ConnexionString);
        conn.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "SELECT * FROM [TYP_ERROR].[dbo].[help]";
        cmd.Connection = conn;
        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        adapter.Fill(dtbl);
        dtbl.Columns[0].ColumnName = "HID";
        dtbl.Columns[1].ColumnName = "ID Thread";
        dtbl.Columns[2].ColumnName = "ID Utilisateur";
        dtbl.Columns[3].ColumnName = "Contenu";
        HelpDataGrid.ItemsSource = dtbl.DefaultView;
        adapter.Update(dtbl);
        cmd.Dispose();
        conn.Close();
    }

    private void UpdateButton_OnClick(object sender, RoutedEventArgs e)
    {
        HelpDataGrid.ItemsSource = null;
        GetHelpInfos();
    }
    
    private void DeleteButton_OnClick(object sender, RoutedEventArgs e)
    {
        DeleteHelpPost window = new DeleteHelpPost();
        window.Show();
    }

    private void QuitButton_OnClick(object sender, RoutedEventArgs e)
    {
        MainWindow window = new MainWindow();
        Close();
        window.Show();
    }

    #endregion

    #region Window Properties

    private void UpdateButton_OnMouseEnter(object sender, MouseEventArgs e)
    {
        UpdateButton.Background = Brushes.Chocolate;
        UpdateButton.Foreground = Brushes.White;
        UpdateButton.Opacity = 1;
    }

    private void UpdateButton_OnMouseLeave(object sender, MouseEventArgs e)
    {
        UpdateButton.Background = Brushes.Transparent;
    }
    
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
    
    private void Moderation_OnMouseDown(object sender, MouseButtonEventArgs e)
    {
        DragMove();
    }

    #endregion
}