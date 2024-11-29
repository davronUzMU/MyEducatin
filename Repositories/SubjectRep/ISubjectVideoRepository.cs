using MyEducatin.Models;

namespace MyEducatin.Repositories.SubjectRep
{
    public interface ISubjectVideoRepository
    {
        List<SubjectVideo> GetSubjectVideoAll();
        SubjectVideo GetSubjectVideoById(int id);
        SubjectVideo AddSubjectVideo(SubjectVideo subject);
        void DeleteSubjectVideo(int id);
    }
}
