using MyEducatin.Models;

namespace MyEducatin.Repositories.CategoryRep
{
    public interface ICategoryImageRepository
    {
        List<CategoryImage> GetCategoryImageAll();
        CategoryImage GetCategoryImageById(int id);
        CategoryImage AddUser(CategoryImage user);
        void Delete(int id);
    }
}
