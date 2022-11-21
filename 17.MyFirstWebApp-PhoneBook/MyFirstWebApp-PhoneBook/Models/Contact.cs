using System.ComponentModel.DataAnnotations;

namespace MyFirstWebApp_PhoneBook.Models
{
    public class Contact
    {
        [Required(ErrorMessage = "The field {0} is required!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The field {0} is required!")]
        [StringLength(15, MinimumLength = 5, ErrorMessage = "The length of the field {0} must be between {2} and {1}")]
        public string Number { get; set; }
    }
}
