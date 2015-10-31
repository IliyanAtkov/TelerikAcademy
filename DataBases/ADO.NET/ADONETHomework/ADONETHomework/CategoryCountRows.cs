namespace ADONETHomework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Data.SqlClient;

    public class CategoryCountRows
    {
        public static void Main()
        {
            SqlConnection dbCon = new SqlConnection("Server=.; " +
            "Database=northwind; Integrated Security=true");
            dbCon.Open();
            using (dbCon)
            {
                SqlCommand catCount = new SqlCommand("SELECT COUNT(CategoryID) FROM Categories", dbCon);
                int categoriesCount = (int)catCount.ExecuteScalar();
                Console.WriteLine("Categories count " + categoriesCount);
            }
        }
    }
}
