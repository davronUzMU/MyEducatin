using System.ComponentModel.DataAnnotations;

namespace MyEducatin.Models
{
    public class Question
    {
        [Key]
        public int Id { get; set; } // Savol uchun unikal identifikator
        [Required]
        public string Text { get; set; } = string.Empty; // Savol matni
        public int TestId { get; set; }
        public Test Test { get; set; }
        public List<Answer> Answers { get; set; } // Ushbu savolga tegishli javoblar
        public int CorrectAnswerId { get; set; } // To'g'ri javobning id
        public State State { get; set; }
    }
}
