using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace ReadFromExcelWithOleDb
{
    class ReadFromExcelWithOleDB
    {
        static void Main(string[] args)
        {
              OleDbConnection dbConn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;" +
            @"Data Source=C:\Users\Producenta\Desktop\ScoreName.xlsx;Extended Properties=""Excel 12.0 XML;HDR=Yes""");
            OleDbCommand myCommand = new OleDbCommand("select * from [Sheet1$]", dbConn);
            dbConn.Open();
            //First way
            //using (dbConn) - I think it is better to use dbConn in using clause, but for the demo issues i dont use using.
            //{
            OleDbDataReader reader = myCommand.ExecuteReader();

            while (reader.Read())
            {
                string name = (string)reader["Name"];
                double score = (double)reader["Score"]; 
                Console.WriteLine("{0} - score: {1}", name, score);
            }
            //}

            dbConn.Close();
            //Second way
            dbConn.Open();
            Console.WriteLine();
            Console.WriteLine("Second Way");
            Console.WriteLine("----------");
            DataTable dataSet = new DataTable();
            OleDbDataAdapter adapter = new OleDbDataAdapter("select * from [Sheet1$]", dbConn);
            adapter.Fill(dataSet);

            foreach (DataRow item in dataSet.Rows)
            {
                Console.WriteLine("{0}|{1}", item.ItemArray[0], item.ItemArray[1]);
            }
            dbConn.Close();
        }
        }
    }
