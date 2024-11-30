using MyEducatin.Models;
using System.ComponentModel.DataAnnotations;

namespace MyEducatin.AllDTO.TestDTO.QuestionDTO
{
    public class QuestionRequestDTO
    {
        public string Text { get; set; } = string.Empty; // Savol matni
        public int TestId { get; set; }
        public List<int> Answers { get; set; } // Ushbu savolga tegishli javoblar
        public int CorrectAnswerId { get; set; } // To'g'ri javobning id
    }
}
