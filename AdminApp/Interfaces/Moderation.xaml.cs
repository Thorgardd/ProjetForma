﻿using System.Windows;

namespace AdminApp.Interfaces;

public partial class Moderation : Window
{
    public Moderation()
    {
        InitializeComponent();
    }

    private void QuitButton_OnClick(object sender, RoutedEventArgs e)
    {
        MainWindow window = new MainWindow();
        Close();
        window.Show();
    }
}