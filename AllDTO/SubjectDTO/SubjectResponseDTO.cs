using MyEducatin.Models;

namespace MyEducatin.AllDTO.SubjectDTO
{
    public class SubjectResponseDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public List<SubjectVideo> SubjectVideo { get; set; }
        public List<Test> tests { get; set; }
        public List<Book> books { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public State State { get; set; }
    }
}
