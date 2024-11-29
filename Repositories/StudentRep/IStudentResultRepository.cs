using MyEducatin.Models;

namespace MyEducatin.Repositories.StudentRep
{
    public interface IStudentResultRepository
    {
        List<StudentResult> GetStudentResultAll();
        StudentResult GetStudentResultById(int id);
        StudentResult AddStudentResult(StudentResult studentResult);
        StudentResult EditStudentResult(StudentResult studentResult);
        void DeleteStudentResult(int id);
    }
}
