namespace AddNewProduct
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Data.SqlClient;

    public class AddNewProduct
    {
        public static void Main()
        {

            AddProduct("Caca", true);
        }

        public static void AddProduct(string name, bool discontinued)
        {
            SqlConnection dbCon = new SqlConnection("Server=.; " +
                   "Database=northwind; Integrated Security=true");
            dbCon.Open();
            using (dbCon)
            {
                SqlCommand addProduct = new SqlCommand("INSERT Products (ProductName,Discontinued)" +
                "VALUES(@name, @discontinued);", dbCon);

                addProduct.Parameters.AddWithValue("@name", name);
                addProduct.Parameters.AddWithValue("@discontinued", discontinued);
                addProduct.ExecuteNonQuery();
            }
        }
    }
}