using Microsoft.AspNetCore.Authorization;
using System.Data;

namespace WebApplication3.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public bool IsAdmin { get; set; }
    }
}
