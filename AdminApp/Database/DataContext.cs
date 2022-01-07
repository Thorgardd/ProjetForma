using System;
using System.Collections.ObjectModel;
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
            try
            {
                string pidValue = pidBoxValue;
                SqlConnection conn = new SqlConnection(ConnexionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "DELETE FROM [TYP_ERROR].[dbo].[partner] WHERE pid=@pid";
                cmd.Parameters.AddWithValue("@pid", pidValue);
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void DeleteHelpControl(string hidBoxValue)
        {
            SqlConnection conn = new SqlConnection(ConnexionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM [TYP_ERROR].[dbo].[help] WHERE hid=@hid";
            cmd.Parameters.AddWithValue("@hid", Convert.ToInt32(hidBoxValue));
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
        }

        public void CloseThread(string yidBoxValue, int isClosed)
        {
            SqlConnection conn = new SqlConnection(ConnexionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE [TYP_ERROR].dbo.why SET status=@status WHERE yid=@yid";
            cmd.Parameters.AddWithValue("@status", isClosed);
            cmd.Parameters.AddWithValue("@yid", yidBoxValue);
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
        }
    }
}