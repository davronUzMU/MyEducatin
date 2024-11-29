using MyEducatin.Models;

namespace MyEducatin.AllDTO.TestDTO
{
    public class TestRequestDTO
    {
        public string Title { get; set; } = string.Empty; // Test nomi
        public string Description { get; set; } = string.Empty; // Test haqida qisqacha ma'lumot
        public int DurationInMinutes { get; set; } // Test uchun belgilangan vaqt (daqiqa hisobida)
        public List<int> Questions { get; set; } // Testga tegishli savollar
        public int SubjectId { get; set; } 
    }
}
