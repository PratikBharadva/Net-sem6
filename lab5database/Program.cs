using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
namespace lab5database
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            SqlConnection conn = new SqlConnection("Data Source=(localdb)\\ProjectModels;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            //inserting data
            cmd.CommandText = "INSERT INTO test values(4,'abc')";
            cmd.ExecuteNonQuery();

            //updating Data
            cmd.CommandText = "UPDATE test SET name='meet' WHERE Id=2";
            cmd.ExecuteNonQuery();
            
            //fetching data
            cmd.CommandText = "SELECT * from test";
            SqlDataReader reader = cmd.ExecuteReader();
            
            while(reader.Read())
            {
                Console.Write(reader[0]+" ");
                Console.WriteLine(reader[1]);
            }
            //closing Connection
            conn.Close();
        }
    }
}
