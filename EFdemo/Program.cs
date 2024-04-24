using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFdemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SchoolContext())
            {
               try
               {
                grade gr1 = new grade() { Gname = "grade 1" };
                grade gr2 = new grade() { Gname = "grade 2" };

                student stud1 = new student() { Name = "Pratik", Grade = gr1 };
                student stud2 = new student() { Name = "Meet", Grade = gr2 };

                context.students.Add(stud1);
                context.students.Add(stud2);
                context.SaveChanges();

                foreach (var s in context.students)
                {
                    Console.WriteLine($"Student name:{s.Name}, grade name: {s.Grade}");
                }
               }
               catch (DbUpdateException ex)
               {
                   Console.WriteLine(ex.InnerException.Message);
               }
            }
        }
    }
}
