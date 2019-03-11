/*Programmer: Matthew Moore
   Description: Access Database
   Date: 11-28-18
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace AccessDatabase
{
    class Program
    {

        static void Main(string[] args)
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\710866\Desktop\FirstDB.accdb";
            string strSQL = "SELECT * FROM Employee";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand command = new OleDbCommand(strSQL, connection);
                try
                {
                    connection.Open();

                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        Console.WriteLine("Original Data");

                        while (reader.Read())
                        {
                            Console.WriteLine($"{reader["FirstName"].ToString()}");
                        }
                    }
                }
                catch  (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.ReadKey();
        }
    }
}
