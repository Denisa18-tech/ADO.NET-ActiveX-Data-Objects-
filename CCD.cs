using Npgsql;
using System;
using System.Data;

namespace ADODemo
{
    class CCD
    {
        public static void RunDemo()
        {
            string connString = "Host=localhost;Port=5432;Username=postgres;Password=Welcome@123;Database=studentdb";

            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    /*Console.WriteLine("Database Connected Successfully\n");

                    string query = "CALL add_student($1, $2, $3, $4, $5)";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue(10);
                        cmd.Parameters.AddWithValue("Rahul");
                        cmd.Parameters.AddWithValue(21);
                        cmd.Parameters.AddWithValue("Civil");
                        cmd.Parameters.AddWithValue("rahul@gmail.com");

                        cmd.ExecuteNonQuery();

                        Console.WriteLine("Student added successfully.");
                    }*/

                    // INSERT Command
                    /*string insertQuery = @"INSERT INTO student(id, name, age, course, email)
                                           VALUES (@id, @name, @age, @course, @email)";

                    using (NpgsqlCommand insertCmd = new NpgsqlCommand(insertQuery, conn))
                    {
                        insertCmd.Parameters.AddWithValue("@id", 7);
                        insertCmd.Parameters.AddWithValue("@name", "Vaishali");
                        insertCmd.Parameters.AddWithValue("@age", 21);
                        insertCmd.Parameters.AddWithValue("@course", "Computer");
                        insertCmd.Parameters.AddWithValue("@email", "vaishali@gmail.com");

                        int rowsInserted = insertCmd.ExecuteNonQuery();

                        Console.WriteLine("Rows Inserted: " + rowsInserted + "\n");

                    }*/

                    //update query
                    /*string updateQuery = "UPDATE student SET email = 'vaishali307@gmail.com' WHERE id = 7";

                    using (NpgsqlCommand updateCmd = new NpgsqlCommand(updateQuery, conn))
                    {
                        int rowupdate = updateCmd.ExecuteNonQuery();

                        Console.WriteLine("Row Update: " + rowupdate + "\n");
                    }*/

                    // Delete query
                    /*string deleteQuery = "DELETE FROM student WHERE id = 8";

                    using (NpgsqlCommand deleteCmd = new NpgsqlCommand(deleteQuery, conn))
                    {
                        int rowdelete = deleteCmd.ExecuteNonQuery();

                        Console.WriteLine("Row delete: " + rowdelete + "\n");
                    }*/


                    //SELECT Command + DataReader
                    string selectQuery = "SELECT id, name, age, course, email FROM student";

                    using (NpgsqlCommand selectCmd = new NpgsqlCommand(selectQuery, conn))
                    using (NpgsqlDataReader reader = selectCmd.ExecuteReader())
                    {
                        Console.WriteLine("Student Records:");
                        Console.WriteLine("-----------------------------------------------------");

                        while (reader.Read())
                        {
                            Console.WriteLine(
                                "ID: " + reader["id"] +
                                ", Name: " + reader["name"] +
                                ", Age: " + reader["age"] +
                                ", Course: " + reader["course"] +
                                ", Email: " + reader["email"]
                            );
                        }
                    }
                    Console.WriteLine("\nData Read Successfully");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            Console.ReadLine();
        }
    }
}