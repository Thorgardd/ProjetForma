using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using AdminApp.Database;
using Microsoft.Data.SqlClient;

namespace AdminApp.Interfaces;

public partial class DeleteHelpPost : Window
{
    public DeleteHelpPost()
    {
        InitializeComponent();
    }

    #region Logique Métier

    private void DeleteButton_OnClick(object sender, RoutedEventArgs e)
    { 
        DataContext DC = new DataContext();
        DC.DeleteHelpControl(HidBox.Text);
        Close();
    }
    
    private void CancelButton_OnClick(object sender, RoutedEventArgs e)
    {
        Close();
    }

    #endregion

    #region Window Properties

    private void DeleteHelpPost_OnMouseDown(object sender, MouseButtonEventArgs e)
    {
        DragMove();
    }
    
    private void HidBox_OnGotFocus(object sender, RoutedEventArgs e)
    {
        HidBox.Text = String.Empty;
        HidBox.Foreground = Brushes.Black;
        HidBox.Opacity = 1;
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