using lab6webapi.Models;
namespace lab6webapi.Interface
{
    public interface IStudent
    {
        public List<Student> GetAllStudent();
        public Student GetStudent(int id);
        public List<Student> GetCity(string c);
    }
}
