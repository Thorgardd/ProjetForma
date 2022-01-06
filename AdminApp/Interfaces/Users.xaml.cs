using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Data;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using AdminApp.Users;

namespace AdminApp.Interfaces;

public partial class Users : Window
{
    DataTable dtbl = new DataTable("partner");
    public Users()
    {
        InitializeComponent();
    }

    #region Logique Métier

    private void BindDataGrid(object sender, RoutedEventArgs e)
    {
        GetUserInfos();
    }

    private void GetUserInfos()
    {
        SqlConnection conn = new SqlConnection(Database.DataContext.ConnexionString);
        conn.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "SELECT * FROM [project].[dbo].[partner]";
        cmd.Connection = conn;
        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        adapter.Fill(dtbl);
        dtbl.Columns.Remove("password");
        dtbl.Columns[0].ColumnName = "PId";
        dtbl.Columns[1].ColumnName = "Nom";
        dtbl.Columns[2].ColumnName = "Administrateur";
        UserDataGrid.ItemsSource = dtbl.DefaultView;
        adapter.Update(dtbl);
        cmd.Dispose();
        conn.Close();
    }
    
    private void ButtonAdd_OnClick(object sender, RoutedEventArgs e)
    {
        AddUserBox msgBox = new AddUserBox();
        msgBox.Show();
    }
    
    private void UpdateButton_OnClick(object sender, RoutedEventArgs e)
    {
        UserDataGrid.ItemsSource = null;
        
    }
    
    private void ButtonDelete_OnClick(object sender, RoutedEventArgs e)
    {
        DeleteUserBox deleteUserBox = new DeleteUserBox();
        deleteUserBox.Show();
    }

    #endregion

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
    private void UpdateButton_OnMouseEnter(object sender, MouseEventArgs e)
    {
        UpdateButton.Background = Brushes.Chocolate;
        UpdateButton.Foreground = Brushes.WhiteSmoke;
        UpdateButton.Opacity = 1;
    }
    
    private void UpdateButton_OnMouseLeave(object sender, MouseEventArgs e)
    {
        UpdateButton.Background = Brushes.Transparent;
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