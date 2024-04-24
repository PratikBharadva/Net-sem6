using lab6webapi.Interface;
using lab6webapi.Models;
using System.Collections;
namespace lab6webapi.Repository
{
    public class StudentRepositery : IStudent
    {
        List<Student> liststudent = new List<Student>
        {
            new Student{Id=1,Name="Pratik",CPI=7.5,City="Surat"},
            new Student{Id=2,Name="Abhishek",CPI=7.8,City="Vadodara"},
            new Student{Id=3,Name="Meet",CPI=8.5,City="Rajkot"}
        };
        public List<Student> GetAllStudent() {
            return liststudent;
        }
        public Student GetStudent(int id)
        {
            return liststudent.FirstOrDefault(s => s.Id == id);
        }
        public List<Student> GetCity(string c)
        {
            var student = (from stud in liststudent
                          where stud.City == c
                          select stud).ToList();
            return student;
        }
    }
}
