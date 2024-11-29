using MyEducatin.Models;

namespace MyEducatin.AllDTO.CourseDTO
{
    public class CourseResponseDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int DurationInWeeks { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public HashSet<Subject> Subjects;
        public State State { get; set; }
    }
}
