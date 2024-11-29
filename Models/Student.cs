using System.ComponentModel.DataAnnotations;

namespace MyEducatin.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string FullName { get; set; }=String.Empty;
        public int age {  get; set; }

        public int studentGroupId {  get; set; }
        public StudentGroup StudentGroup { get; set; }
        public string PhoneNummeric {  get; set; }=String.Empty ;
        public List<StudentResult> StudentResults { get; set; } 
        public DateTime DateTime { get; set; }
        public State State { get; set; }

    }
}
