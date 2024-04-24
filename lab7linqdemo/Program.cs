using System;
using System.Collections;
namespace lab7linqdemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LINQ for array:");
            //linq query for array
            int[] ar = { 1, 2, 3, 4, 5 };

            var count = from i in ar
                        where (i % 2)==1
                        select i;
            foreach (int i in count)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            //linq query for collection class
            Console.WriteLine("LINQ for list:");
            List<string> names = new List<string>();
            names.Add("Pratik");
            names.Add("Meet");
            names.Add("Abhishek");

            IEnumerable<string> values = from name in names
                                         where name.Length>4
                                         select name;    
            foreach(string n in values)
            {
                Console.Write(n + " ");
            }
        }
    }
}
