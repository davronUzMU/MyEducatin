using MyEducatin.Models;

namespace MyEducatin.Repositories.TestRep
{
    public interface IAnswerRepository
    {
        List<Answer> GetAnswerAll();
        Answer GetAnswerById(int id);
        Answer AddAnswer(Answer answer);
        Answer EditAnswer(Answer answer);
        void DeleteAnswer(int id);
    }
}
