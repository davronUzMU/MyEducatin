using MyEducatin.Models;

namespace MyEducatin.Repositories.CategoryRep
{
    public interface ICategoryRepository
    {
        List<Category> GetCategoryAll();
        Category GetCategoryById(int id);
        Category AddCategory(Category category);
        Category EditCategory(Category category);
        void Delete(int id);
    }
}
