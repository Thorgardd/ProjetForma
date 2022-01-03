using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Data;
using Microsoft.Data.SqlClient;

namespace ProjetForma.Interfaces;

public partial class Users : Window
{
    public Users()
    {
        InitializeComponent();
    }
    
    private void BindDataGrid(object sender, RoutedEventArgs e)
    {
        SqlConnection conn = new SqlConnection(Database.DataContext.ConnexionString);
        conn.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "SELECT * FROM [project].[dbo].[partner]";
        cmd.Connection = conn;
        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        DataTable dtbl = new DataTable("partner");
        adapter.Fill(dtbl);
        dtbl.Columns.Remove("password");
        UserDataGrid.ItemsSource = dtbl.DefaultView;
        adapter.Update(dtbl);
        conn.Close();
    }
    
    private void ButtonDelete_OnClick(object sender, RoutedEventArgs e)
    {
        
    }

    #region Window Properties

    private void Users_OnMouseDown(object sender, MouseButtonEventArgs e)
    {
        DragMove();
    }

    private void ButtonAdd_OnMouseEnter(object sender, MouseEventArgs e)
    {
        ButtonAdd.Background = Brushes.Chocolate;
        ButtonAdd.Foreground = Brushes.WhiteSmoke;
        ButtonAdd.Opacity = 1;
    }

    private void ButtonAdd_OnMouseLeave(object sender, MouseEventArgs e)
    {
        ButtonAdd.Background = Brushes.Transparent;
    }

    private void ButtonDelete_OnMouseEnter(object sender, MouseEventArgs e)
    {
        ButtonDelete.Background = Brushes.Chocolate;
        ButtonDelete.Foreground = Brushes.WhiteSmoke;
        ButtonDelete.Opacity = 1;
    }

    private void ButtonDelete_OnMouseLeave(object sender, MouseEventArgs e)
    {
        ButtonDelete.Background = Brushes.Transparent;
    }

    private void ButtonLeave_OnMouseEnter(object sender, MouseEventArgs e)
    {
        ButtonLeave.Background = Brushes.DarkRed;
        ButtonLeave.Foreground = Brushes.WhiteSmoke;
        ButtonLeave.Opacity = 1;
    }

    private void ButtonLeave_OnMouseLeave(object sender, MouseEventArgs e)
    {
        ButtonLeave.Background = Brushes.Transparent;
    }
    
    private void ButtonLeave_OnClick(object sender, RoutedEventArgs e)
    {
        MainWindow window = new MainWindow();
        Close();
        window.Show();
    }

    #endregion
}