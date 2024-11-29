using System.ComponentModel.DataAnnotations;

namespace MyEducatin.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; } 
        [Required]
        public string BookName { get; set; } = string.Empty; // Kitobning nomi
        public string Author { get; set; } = string.Empty; // Muallifning ismi
        public DateTime PublishedDate { get; set; } // Nashr qilingan sana
        public string Genre { get; set; } = string.Empty; // Janr (masalan: Fantastika, Detektiv)
        public int PageCount { get; set; } // Kitobdagi sahifalar soni
        public string Description { get; set; } = string.Empty; // Kitob haqida qisqacha ma'lumot
        public string CoverImageUrl { get; set; } = string.Empty; // Muqova rasmi uchun URL
        public decimal Price { get; set; } // Kitob narxi
        public State State { get; set; }
        public int ImgId { get; set; }

        public string FileName { get; set; } = string.Empty; // Yuklangan fayl nomi (masalan: book.pdf)
        public string FilePath { get; set; } = string.Empty; // Fayl serverdagi joylashuvi (masalan: wwwroot/books/)
        public string FileUrl { get; set; } = string.Empty; // Agar foydalanuvchilar yuklab olishi uchun URL bo'lsa

        public int SubjectId { get; set; } 
        public Subject Subject { get; set; } 
    }
}
