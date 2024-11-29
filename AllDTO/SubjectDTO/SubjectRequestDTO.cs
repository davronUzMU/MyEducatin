using MyEducatin.Models;

namespace MyEducatin.AllDTO.SubjectDTO
{
    public class SubjectRequestDTO
    {
        public string Name { get; set; } = String.Empty;
        public List<int> SubjectVideo { get; set; }
        public List<int> tests { get; set; }
        public List<int> books { get; set; }
        public int CourseId { get; set; }
    }
}
