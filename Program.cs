using ADODemo;
using Npgsql;
using System;

class Program
{

    static void Main(string[] args)
    {
        //CCD.RunDemo();
        Query.QueryDemo();
        //Method.MethodDemo();
    
    string connString = "Host=localhost;Port=5432;Username=postgres;Password=Welcome@123;Database=studentdb";

        using (NpgsqlConnection conn = new NpgsqlConnection(connString))
        {
            conn.Open();

           
            string query = "SELECT id, name, age, course FROM student";

            using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
            {
                /*using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine(
                            reader["id"] + " | " +
                            reader["name"] + " | " +
                            reader["age"] + " | " +
                            reader["course"]);
                    }
                }*/
            }

            //string query = "INSERT INTO student(id, name, age, course, email) VALUES (6, 'Rahul', 21, 'Computer', 'rahul@gmail.com')";
            //string query1 = "UPDATE student SET name = 'Rahul Kumar' WHERE id = 7";
            //string query2 = "DELETE FROM student WHERE id = 7";
            /*string query = "SELECT COUNT(*) FROM student";
            using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
            {
                
                int rows = cmd.ExecuteNonQuery();

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                //Console.WriteLine("Total Students: " + count);

                //Console.WriteLine("Rows Inserted: " + rows);
                //Console.WriteLine("Updated Successfully");
                //Console.WriteLine("Deleted Successfully");
              }*/

        }
    }
}