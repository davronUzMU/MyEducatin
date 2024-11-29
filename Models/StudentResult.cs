using System.ComponentModel.DataAnnotations;

namespace MyEducatin.Models
{
    public class StudentResult
    {
        [Key] 
       public int Id { get; set; }
       public string subject { get; set; }=String.Empty;
       public decimal studentResultScore { get; set; }
       public decimal MaxScore { get; set; }
       public decimal CorrectAnswerPercentage { get; set; }
       public int StudentId { get; set; }
       public Student student { get; set; }

       public State State { get; set; }

    }
}
