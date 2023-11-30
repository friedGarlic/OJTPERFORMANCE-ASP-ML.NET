using System.ComponentModel.DataAnnotations;

namespace ML_ASP.Models
{
    public class Account_Model
    {
        [Key]
        public Guid Id { get; set; }
        public int Age { get; set; }
        public string FullName { get; set; }

        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
