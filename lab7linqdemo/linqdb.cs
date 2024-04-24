using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Data.SqlClient;

namespace lab7linqdemo
{
    internal class stud
    {
        public int id { get; set; }
        public string name { get; set; }
        public int spi { get; set; }
    }
    internal class linqdb
    {
        static void Main(string[] args)
        {
            SqlConnection conn = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = Student; Integrated Security = True;");
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;

            cmd.CommandText = "Select * from stud";
            SqlDataReader reader = cmd.ExecuteReader();
            List<stud> students = new List<stud>();
            while (reader.Read())
            {
                students.Add(new stud { id = Convert.ToInt32(reader[0]), name = Convert.ToString(reader[1]), spi = Convert.ToInt32(reader[2]) });
            }
            foreach(stud student in students)
            {
                Console.WriteLine(student.id + " " + student.name + " " + student.spi);
            }

            Console.WriteLine("Linq query::");
            var values = from i in students
                         where i.spi >= 8
                         select i.name;

            foreach (string n in values)
            {
                Console.Write(n + " ");
            }
        }
    }
}
