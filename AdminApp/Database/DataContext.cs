using System;
using AdminApp.Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace AdminApp.Database
{
    public class DataContext
    {
        #region Attributs

        public static string ConnexionString = @"Data Source=(LocalDb)\Projet;Integrated Security=true";
        string[] defaultPassword = {"wearehere", "defaultpassword", "syracuse", "iwillbechanged"};
        private Random rnd = new ();

        #endregion
        
        public void AddUserControl(string nameBoxValue, bool isAdminBoxValue)
        {
            string name = nameBoxValue;
            int password = rnd.Next(defaultPassword.Length);
            SqlConnection conn = new SqlConnection(ConnexionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO [TYP_ERROR].[dbo].[partner] VALUES (@name, @password, @isAdmin)";
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@password", defaultPassword[password]);
            cmd.Parameters.AddWithValue("@isAdmin", isAdminBoxValue);
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
            
        }

        public void DeleteUserControl(string pidBoxValue)
        {
            SqlConnection conn = new SqlConnection(ConnexionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM [TYP_ERROR].[dbo].[partner] WHERE pid=@pid";
            cmd.Parameters.AddWithValue("@pid", Convert.ToInt32(pidBoxValue));
            cmd.Connection = conn;
            var reader = cmd.ExecuteReader();
            cmd.Dispose();
            conn.Close();
        }

        public void DeleteHelpControl(string hidBoxValue)
        {
            SqlConnection conn = new SqlConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM [TYP_ERROR].[dbo].[help] WHERE hid=@hid";
            cmd.Parameters.AddWithValue("@hid", Convert.ToInt32(hidBoxValue));
            cmd.Connection = conn;
            var reader = cmd.ExecuteReader();
            cmd.Dispose();
            conn.Close();
        }
    }
}