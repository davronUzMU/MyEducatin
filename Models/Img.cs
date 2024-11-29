using System.ComponentModel.DataAnnotations;

namespace MyEducatin.Models
{
    public class Img
    {
        [Key]
        public int Id { get; set; } 
        public string FileName { get; set; } = string.Empty; // Fayl nomi (masalan: image1.jpg)
        public string FilePath { get; set; } = string.Empty; // Serverdagi joylashuvi (masalan: wwwroot/images/)
        public string Url { get; set; } = string.Empty; // Agar fayl tashqi resursda bo'lsa
        public DateTime UploadedAt { get; set; } // Yuklangan sana va vaqt
        public State State { get; set; }
    }
}
