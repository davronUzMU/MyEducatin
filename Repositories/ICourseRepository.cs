using MyEducatin.Models;

namespace MyEducatin.Repositories
{
    public interface ICourseRepository
    {
        List<Course> GetCourseAll();
        Course GetCourseById(int id);
        Course AddCourse(  Course subject);
        Course EditCourse(Course subject);
        void DeleteCourse(int id);
    }
}
