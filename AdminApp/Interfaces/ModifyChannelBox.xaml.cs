using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using AdminApp.Database;

namespace AdminApp.Interfaces;

public partial class ModifyChannelBox : Window
{
    public ModifyChannelBox()
    {
        InitializeComponent();
    }

    #region Logique Métier

    private void ModifyButton_OnClick(object sender, RoutedEventArgs e)
    {
        int status = 1;
        DataContext DC = new DataContext();
        if (SetClosed.IsChecked == true)
            status = 0;
        else if (SetOpen.IsChecked == true)
            status = 1;
            
        DC.CloseThread(WhyIdBox.Text, status);
        Close();
    }
    
    
    
    private void CancelButton_OnClick(object sender, RoutedEventArgs e)
    {
        Close();
    }

    #endregion

    #region Window Properties

    
    private void ModifyChannelBox_OnMouseDown(object sender, MouseButtonEventArgs e)
    {
        DragMove();
    }
    private void WhyIdBox_OnGotFocus(object sender, RoutedEventArgs e)
    {
        WhyIdBox.Text = String.Empty;
        WhyIdBox.Foreground = Brushes.Black;
        WhyIdBox.Opacity = 1;
    }

    private void ModifyButton_OnMouseEnter(object sender, MouseEventArgs e)
    {
        ModifyButton.Background = Brushes.DarkGreen;
        ModifyButton.Foreground = Brushes.White;
        ModifyButton.Opacity = 1;
    }
    
    private void ModifyButton_OnMouseLeave(object sender, MouseEventArgs e)
    {
        ModifyButton.Background = Brushes.Transparent;
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