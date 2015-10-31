using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace WriteInExcelFile
{
    class WriteInExcelFile
    {
        static void Main()
        {
            OleDbConnection dbConn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;" +
            @"Data Source=..\..\..\ScoreName.xlsx;Extended Properties=""Excel 12.0 XML;HDR=Yes""");

        for (int i = 1; i < 10; i++)
        {
            InsertDataIntoEcxel("Nakov" + i, i, dbConn);
        }
    }

    static void InsertDataIntoEcxel(string name, double score, OleDbConnection connection)
    {
        OleDbCommand myCommand = new OleDbCommand("INSERT INTO [Sheet1$] (Name,Score) VALUES (@Name,@Score)", connection);
        connection.Open();
        myCommand.Parameters.AddWithValue("@Name", name);
        myCommand.Parameters.AddWithValue("@Score", score);
        myCommand.ExecuteNonQuery();
        connection.Close();
    }
        }
    }
