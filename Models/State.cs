using System.ComponentModel.DataAnnotations;

namespace MyEducatin.Models
{
    public class State
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = String.Empty;

        public bool IsActive { get; set; }
    }
}
