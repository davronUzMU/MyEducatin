using MyEducatin.Models;

namespace MyEducatin.Repositories.StudentRep
{
    public interface IStudentRepository
    {
        List<Student> GetStudentAll();
        Student GetStudentById(int id);
        Student AddStudent(Student user);
        Student EditStudent(Student user);
        void DeleteStudent(int id);
    }
}
