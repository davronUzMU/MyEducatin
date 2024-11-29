using MyEducatin.Models;

namespace MyEducatin.AllDTO.CategoryDTO.CategoryImageDTO
{
    public class CategoryImageRequestDTO
    {
        public string MainFileName { get; set; } = string.Empty; // Fayl nomi (masalan: image1.jpg)
        public string MainFilePath { get; set; } = string.Empty; // Serverdagi joylashuvi (masalan: wwwroot/images/)
        public string MainUrl { get; set; } = string.Empty; // Agar fayl tashqi resursda bo'lsa
    }
}
