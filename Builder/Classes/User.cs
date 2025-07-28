using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Classes
{
    public record class User
    {
        public string Username { get; init; }
        public string Password { get; init; }
        public string Email { get; init; }
        public string Phone { get; init; }
        public string Address { get; init; }
        public DateTime? BirthDate { get; init; }

    }
}
