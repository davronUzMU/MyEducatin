using MyEducatin.Models;

namespace MyEducatin.Repositories.TestRep
{
    public interface ITestRepository
    {
        List<Test> GetTestAll();
        Test GetTestById(int id);
        Test AddTest(Test test);
        Test EditTest(Test test);
        void DeleteTest(int id);
    }
}
