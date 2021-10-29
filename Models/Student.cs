using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Assignment1.Models {
    public class Student {
        [Display(Name = "ID")]
        public int StudentId { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "The student's first name is required.")]
        [MaxLength(40)]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "The student's last name is required.")]
        [MaxLength(40)]
        public string LastName { get; set; }

        [Display(Name = "Mobile Number")]
        [Required(ErrorMessage = "Please enter a mobile number.")]
        [MaxLength(15)]
        public string Mobile { get; set; }

        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "Please enter an email address.")]
        [MaxLength(200)]
        public string Email { get; set; }

        [Display(Name = "City of Residence")]
        [Required(ErrorMessage = "The student's city of residence is required.")]
        [MaxLength(25)]
        public string City { get; set; }

        [Required(ErrorMessage = "The student's specialization in school is required.")]
        [MaxLength(25)]
        public string Specialization {get; set; }

        public List<Student> Students { get; set; }

    }
}