using MyEducatin.Models;

namespace MyEducatin.Repositories
{
    public interface IStateRepository
    {
        List<State> GetSubjectAll();
        State GetSubjectById(int id);
        Img AddSubject(State state);
        void DeleteSubject(int id);
    }
}
