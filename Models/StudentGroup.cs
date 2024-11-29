using System.ComponentModel.DataAnnotations;

namespace MyEducatin.Models
{
    public class StudentGroup
    {
        [Key]
        public int Id { get; set; } // Guruh uchun unikal identifikator
        public string Name { get; set; } = string.Empty; // Guruh nomi
        public string Description { get; set; } = string.Empty; // Guruh haqida ma'lumot
        public int Capacity { get; set; } // Guruh maksimal sig'imi
        public List<Student> Students { get; set; } = new(); // Ushbu guruhdagi talabalar
        public State State { get; set; }
    }
}
