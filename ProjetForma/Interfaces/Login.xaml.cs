using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using Microsoft.Data.SqlClient;

namespace ProjetForma.Interfaces
{
    public partial class Login : Window
    {
        private string? UserName;
        private string? PassWord;
        
        public Login()
        {
            InitializeComponent();
        }

        #region Logique Métier

        /// <summary>
        /// Méthode utilisée pour vérifier les données de connexion dans la méthode de click sur le bouton LOGIN
        /// </summary>
        private void VerifyCredentials()
        {
            string name = Username.Text;
            string password = Password.Password;
            SqlConnection conn = new SqlConnection(Database.DataContext.ConnexionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = $"SELECT * FROM [project].[dbo].[partner] WHERE name=@Username AND password=@Password";
            cmd.Parameters.AddWithValue("@Username", name);
            cmd.Parameters.AddWithValue("@Password", password);
            cmd.Connection = conn;
            var reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    if (name == reader["name"].ToString() && password == reader["password"].ToString() && reader["isAdmin"].ToString() == "1")
                    {
                        CreateMainWindow();
                    }
                    else if (name != reader["name"].ToString() || password != reader["password"].ToString() || reader["isAdmin"].ToString() != "1")
                    {
                        LogStatus.Foreground = Brushes.Red;
                        LogStatus.Visibility = Visibility.Visible;

                    }
                }
            }
            cmd.Dispose();
            conn.Close();
        }
        
        /// <summary>
        /// Méthode appelée lorsque l'utilisateur clique sur LOGIN
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_OnClick(object sender, RoutedEventArgs e)
        {
            VerifyCredentials();
        }
        
        /// <summary>
        /// Méthode de création de la fenêtre principale
        /// </summary>
        private void CreateMainWindow()
        {
            MainWindow window = new MainWindow();
            window.Show();
            Close();
        }
        
        /// <summary>
        /// Méthode utilisée lorsque l'utilisateur click sur QUITTER
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonLeave_OnClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        #endregion

        #region Window Properties

        // Focus sur le champ USERNAME
        private void Username_OnGotFocus(object sender, RoutedEventArgs e)
        {
            Username.Text = String.Empty;
            Username.Foreground = Brushes.WhiteSmoke;
            Username.Opacity = 1;
        }
        
        // Effet lorsque l'utilisateur survole le bouton LOGIN
        private void Button_OnMouseEnter(object sender, MouseEventArgs e)
        {
            Button.Foreground = Brushes.WhiteSmoke;
            Button.Background = Brushes.DarkGreen;
            Button.Opacity = 1;
        }

        // Effet lorsqe l'utilisateur quitte le survole du bouton LOGIN
        private void Button_OnMouseLeave(object sender, MouseEventArgs e)
        {
            Button.Background = Brushes.Transparent;
        }

        // Focus sur le champ PASSWORD
        private void Password_OnGotFocus(object sender, RoutedEventArgs e)
        {
            Password.Password = String.Empty;
            Password.Foreground = Brushes.WhiteSmoke;
            Password.Opacity = 1;
        }
        
        // Si l'utilisateur appuie sur ENTREE pour valider le formulaire de connexion
        private void Password_OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                VerifyCredentials();
            }
        }

        // Effet lorsque l'utilisateur survole le bouton QUITTER
        private void ButtonLeave_OnMouseEnter(object sender, MouseEventArgs e)
        {
            ButtonLeave.Background = Brushes.DarkRed;
            ButtonLeave.Foreground = Brushes.White;
            ButtonLeave.Opacity = 1;
        }

        // Effet lorsque l'utilisateur 
        private void ButtonLeave_OnMouseLeave(object sender, MouseEventArgs e)
        {
            ButtonLeave.Background = Brushes.Transparent;
        }

        #endregion
    }
}
