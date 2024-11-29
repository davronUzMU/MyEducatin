using MyEducatin.Models;

namespace MyEducatin.Repositories.TestRep
{
    public interface IQuestionRepository
    {
        List<Question> GetQuestionAll();
        Question GetQuestionById(int id);
        Question AddQuestion(Question question);
        Question EditQuestion(Question question);
        void DeleteQuestion(int id);
    }
}
