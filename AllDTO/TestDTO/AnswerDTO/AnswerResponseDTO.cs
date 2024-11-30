using MyEducatin.Models;

namespace MyEducatin.AllDTO.TestDTO.AnswerDTO
{
    public class AnswerResponseDTO
    {
        public int Id { get; set; }
        public string Text { get; set; } = string.Empty; // Javob matni
        public bool IsCorrect { get; set; } // Javob to'g'ri yoki noto'g'ri ekanligini belgilaydi
        public int QuestionId { get; set; } // Ushbu javob qaysi savolga tegishli ekanligi
        public Question Question { get; set; }
        public State State { get; set; }
    }
}
