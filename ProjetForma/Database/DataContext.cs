using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace ProjetForma.Database
{
    public class DataContext
    {
        public static string ConnexionString = @"Data Source=(LocalDb)\RedLineProject;Integrated Security=true";
    }
}