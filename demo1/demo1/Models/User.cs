using System;
using System.Collections.Generic;

namespace demo1.Models
{
    public partial class User
    {
        public int Uid { get; set; }
        public string Uname { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
