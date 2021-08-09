using System.ComponentModel.DataAnnotations;

namespace CineMania.Models
{
    public class ContactInfo
    { 
        [Key]
        public int  Id { get; set; }
        [Required(ErrorMessage= "you have to enter your name")]
        
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        public string Message { get; set; }
    }
}