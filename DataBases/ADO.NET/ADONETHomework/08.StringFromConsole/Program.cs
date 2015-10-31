using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace StringFromConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection connection = new SqlConnection("Server=.; " +
            "Database=northwind; Integrated Security=true");
            Console.Write("Search: ");
            string input = Console.ReadLine();
            string[] inputSeparator = input.Split(new char[] { '_', '\'', '%', '\"', '\\' });

            if (inputSeparator.Length > 1)
            {
                Console.WriteLine("Are you trying SQL Injection?");
            }
            else
            {
                FindProduct(input, connection);
            }
        }

        static void FindProduct(string searchedSubstring, SqlConnection connection)
        {
            SqlCommand command = new SqlCommand("SELECT ProductName FROM Products WHERE ProductName Like @searchedSubstring;", connection);
            command.Parameters.AddWithValue("@searchedSubstring", "%" + searchedSubstring + "%");
            connection.Open();
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                string product = (string)reader["ProductName"];
                Console.WriteLine(product);
            }
        }
    }
}
