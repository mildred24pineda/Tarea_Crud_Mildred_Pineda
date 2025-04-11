
using Microsoft.Data.SqlClient;

namespace Tarea_crud_
{
    public static class DatabaseHelper
    {
        private static string connectionString = "Server=MILDRED-PINEDA\\SQLEXPRESS;Database=UMG;Trusted_Connection=True;TrustServerCertificate=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}