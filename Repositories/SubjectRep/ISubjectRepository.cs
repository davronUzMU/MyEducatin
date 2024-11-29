using MyEducatin.Models;

namespace MyEducatin.Repositories.SubjectRep
{
    public interface ISubjectRepository
    {
        List<Subject> GetSubjectAll();
        Subject GetSubjectById(int id);
        Subject AddSubject(Subject subject);
        Subject EditSubject(Subject subject);
        void DeleteSubject(int id);
    }
}
