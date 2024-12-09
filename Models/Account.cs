using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace YalabenaApi.Models
{
    public class Account
    {
        public int AccountId { get; set; }
        public string Username { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string PasswordHash { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DbSet<User> GuestUsers { get; set; }
    }

}
