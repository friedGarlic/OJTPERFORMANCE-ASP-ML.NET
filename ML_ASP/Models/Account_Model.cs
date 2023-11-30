using System.ComponentModel.DataAnnotations;

namespace ML_ASP.Models
{
    public class Account_Model
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
