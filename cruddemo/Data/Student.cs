using System.ComponentModel.DataAnnotations;

namespace cruddemo.Data
{
    public class Student
    {
        [Key]
        [Display(Name = "Student ID")]

        public string StudId { get; set; }
        
        [Required]
        [Display(Name = "Student Name")]
        
        public string Name { get; set; }

        public string Email { get; set; }

        public string course { get; set; }

        [Display(Name = "Enrollment Date")]
        public DateTime Enrollmentdate  { get; set; }
    }
}
