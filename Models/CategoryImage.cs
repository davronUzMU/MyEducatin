using System.ComponentModel.DataAnnotations;

namespace MyEducatin.Models
{
    public class CategoryImage
    {
        [Key]
        public int Id { get; set; }
        public string MainFileName { get; set; } = string.Empty; // Fayl nomi (masalan: image1.jpg)
        public string MainFilePath { get; set; } = string.Empty; // Serverdagi joylashuvi (masalan: wwwroot/images/)
        public string MainUrl { get; set; } = string.Empty; // Agar fayl tashqi resursda bo'lsa
        public DateTime UploadedAt { get; set; } // Yuklangan sana va vaqt
        public State State { get; set; }
    }
}
