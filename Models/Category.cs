using System.ComponentModel.DataAnnotations;

namespace MyEducatin.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }=String.Empty;
        public int CategoryImageId { get; set; }
        public DateTime DateTime { get; set; }
        public HashSet<Course> Courses {  get; set; }
        public State State { get; set; }
    }
}
