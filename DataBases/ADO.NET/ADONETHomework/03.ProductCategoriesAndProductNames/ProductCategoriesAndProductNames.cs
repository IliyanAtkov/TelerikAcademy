namespace ProductCategoriesAndProductNames
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Data.SqlClient;

    public class ProductCategoriesAndProductNames
    {
        public static void Main()
        {
            SqlConnection dbCon = new SqlConnection("Server=.; " +
           "Database=northwind; Integrated Security=true");
            dbCon.Open();
            using (dbCon)
            {
                SqlCommand catNameAndDescpription = new SqlCommand(
                    "SELECT p.ProductName, c.CategoryName FROM Products p JOIN Categories c ON c.CategoryID = p.CategoryID", dbCon);
                SqlDataReader reader = catNameAndDescpription.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        string productName = (string)reader["ProductName"];
                        string categoryName = (string)reader["CategoryName"];
                        Console.WriteLine("Product name " + productName + " " + "Category Name " + categoryName);
                    }

                }
            }
        }
    }
}
