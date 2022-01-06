using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace AdminApp.Database
{
    public struct DataContext
    {
        public static string ConnexionString = @"Data Source=(LocalDb)\RedLineProject;Integrated Security=true";
    }
}