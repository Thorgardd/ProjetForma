using System.Data;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace AdminApp.Interfaces;

public partial class Channels : Window
{
    public Channels()
    {
        InitializeComponent();
    }

    #region Logique Métier

    private void BindDataGrid(object sender, RoutedEventArgs routedEventArgs)
    {
        GetWhyInfos();
    }

    private void GetWhyInfos()
    {
        DataTable dtbl = new DataTable("why");
        SqlConnection conn = new SqlConnection(Database.DataContext.ConnexionString);
        conn.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "SELECT * FROM [TYP_ERROR].[dbo].[why]";
        cmd.Connection = conn;
        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        adapter.Fill(dtbl);
        dtbl.Columns[0].ColumnName = "YID";
        dtbl.Columns[1].ColumnName = "ID Catégorie";
        dtbl.Columns[2].ColumnName = "ID Créateur";
        dtbl.Columns[3].ColumnName = "Nom Post";
        dtbl.Columns[4].ColumnName = "Description";
        dtbl.Columns[5].ColumnName = "Code Sample";
        dtbl.Columns[6].ColumnName = "Statut";
        ChannelDataGrid.ItemsSource = dtbl.DefaultView;
        adapter.Update(dtbl);
        cmd.Dispose();
        conn.Close();
    }
    
    private void ModifyButton_OnClick(object sender, RoutedEventArgs e)
    {
        ModifyChannelBox msgbox = new ModifyChannelBox();
        msgbox.Show();
    }
    
    private void UpdateButton_OnClick(object sender, RoutedEventArgs e)
    {
        ChannelDataGrid.ItemsSource = null;
        GetWhyInfos();
    }
    
    private void QuitButton_OnClick(object sender, RoutedEventArgs e)
    {
        MainWindow window = new MainWindow();
        Close();
        window.Show();
    }

    #endregion

    #region Window Properties

    private void Channels_OnMouseDown(object sender, MouseButtonEventArgs e)
    {
        DragMove();
    }
    
    private void ModifyButton_OnMouseEnter(object sender, MouseEventArgs e)
    {
        ModifyButton.Background = Brushes.Chocolate;
        ModifyButton.Foreground = Brushes.White;
        ModifyButton.Opacity = 1;
    }

    private void ModifyButton_OnMouseLeave(object sender, MouseEventArgs e)
    {
        ModifyButton.Background = Brushes.Transparent;
    }
    
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