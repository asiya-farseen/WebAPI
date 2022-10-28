using System;
using System.Collections.Generic;

namespace assignment.Models
{
    public partial class User
    {
        public int Userid { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public long Mobile { get; set; }
        public string Address { get; set; } = null!;
        public long Zipcode { get; set; }
        public string City { get; set; } = null!;
        public string Locality { get; set; } = null!;
        public string Password { get; set; } = null!;
        public int Roleid { get; set; }
    }
}
