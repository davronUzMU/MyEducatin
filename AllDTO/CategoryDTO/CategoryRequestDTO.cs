using MyEducatin.Models;

namespace MyEducatin.AllDTO.CategoryDTO
{
    public class CategoryRequestDTO
    {
        public string Name { get; set; } = String.Empty;
        public int CategoryImageId { get; set; }
        public HashSet<int> Courses { get; set; }= new HashSet<int>();
    }
}
