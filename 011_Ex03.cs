namespace Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            string connStr = "Data Sorce = (local) ; Integerated Security = true";
            string sql = "SELECT COUNT(1) FROM EX03.cs";
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(connStr);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                object count = cmd.ExecuteScalar();
                Console.WriteLine(count);
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if ( conn != null && conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
    }
}