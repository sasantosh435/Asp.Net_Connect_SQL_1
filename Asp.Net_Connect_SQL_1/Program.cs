using System;
using System.Data.SqlClient;

namespace Asp.Net_Connect_SQL_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Server=SANTHOSH\\MSSQLSANDY;Database=student;Trusted_Connection=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT * FROM Employee_Name";

                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        // Access each value by column name, and call the ToString() method to convert the value to a string
                        string firstName = dr["FirstName"].ToString();
                        string lastName = dr["LastName"].ToString();
                        //int Age =(int)dr["Age"];
                        Console.WriteLine(firstName + " " + lastName);
                        Console.WriteLine("Age");
                    }
                    dr.Close();
                }
            }
            Console.ReadKey();
        }
    }
}
