using MyEducatin.Models;

namespace MyEducatin.AllDTO.CategoryDTO
{
    public class CategoryResponseDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public int CategoryImageId { get; set; }
        public DateTime DateTime { get; set; }
        public HashSet<Course> Courses { get; set; }
        public State State { get; set; }
    }
}
