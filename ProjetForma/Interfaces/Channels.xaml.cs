﻿using System.Windows;

namespace ProjetForma.Interfaces;

public partial class Channels : Window
{
    public Channels()
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