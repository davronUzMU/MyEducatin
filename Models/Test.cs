using System.ComponentModel.DataAnnotations;

namespace MyEducatin.Models
{
    public class Test
    {
        [Key]
        public int Id { get; set; } // Test uchun unikal id
        public string Title { get; set; } = string.Empty; // Test nomi
        public string Description { get; set; } = string.Empty; // Test haqida qisqacha ma'lumot
        public int DurationInMinutes { get; set; } // Test uchun belgilangan vaqt (daqiqa hisobida)
        public DateTime DateTime { get; set; }
        public List<Question> Questions { get; set; } = new(); // Testga tegishli savollar

        public int SubjectId { get; set; } // Foreign Key
        public Subject Subject { get; set; } // Navigation Property

        public State State { get; set; }
    }
}

