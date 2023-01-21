using System.Data.SqlClient;

namespace OOAD_Project
{
    internal class SQLConnection
    {
        public static string connectionString = @"Data Source=BLACKY\BLACKY;Initial Catalog=DISC_SHOP_MANAGEMENT;Integrated Security=True";
        public static string GetFieldValues(string SQL)
        {
            string result = "";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(SQL, connection);
            SqlDataReader reader;

            connection.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
                result = reader.GetValue(0).ToString();
            reader.Close();
            connection.Close();

            return result;
        }
    }
}
