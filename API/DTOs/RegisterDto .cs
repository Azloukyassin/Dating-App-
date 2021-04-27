using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class RegisterDto 
    { 
        [Required]
        public string Userrname { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}