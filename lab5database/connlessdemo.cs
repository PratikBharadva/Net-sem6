using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5database
{
    public class connlessdemo
    {
        public static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\ProjectModels;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;");
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM test", con);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            foreach(DataRow row in ds.Tables[0].Rows)
            {
                Console.WriteLine(row[0]);
                Console.WriteLine(row[1]);
            }
        }
    }
}
