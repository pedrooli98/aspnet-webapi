using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project_tests.Models
{
    public class User
    {
        public int Id { get; set; }
        public String Username { get; set; } = string.Empty;
        public String Email { get; set; } = string.Empty;
        public byte[] PasswordHash { get; set; } = new byte[0];
        public byte[] PasswordSalt { get; set; } = new byte[0];
    }
}