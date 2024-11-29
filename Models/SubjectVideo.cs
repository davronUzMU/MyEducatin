using System.ComponentModel.DataAnnotations;

namespace MyEducatin.Models
{
    public class SubjectVideo
    {
        [Key]
        public int Id { get; set; } 

        public string SubjectVideoName { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty; 

        public string FilePath { get; set; } = string.Empty; // Video faylining saqlanadigan yo'li

        public DateTime UploadDate { get; set; } 

        public long FileSize { get; set; } 

        public int SubjectId { get; set; } 
        public Subject Subject { get; set; }
    }
}
