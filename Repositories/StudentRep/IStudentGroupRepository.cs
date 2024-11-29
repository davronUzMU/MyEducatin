using MyEducatin.Models;

namespace MyEducatin.Repositories.StudentRep
{
    public interface IStudentGroupRepository
    {
        List<StudentGroup> GetStudentGroupAll();
        StudentGroup GetStudentGroupById(int id);
        StudentGroup AddStudentGroup(StudentGroup studentGroup);
        StudentGroup EditStudentGroup(StudentGroup studentGroup);
        void DeleteStudentGroup(int id);
    }
}
