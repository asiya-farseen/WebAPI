using System;
using System.Collections.Generic;

namespace localdemowebapi.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public long Mobile { get; set; }
        public string Password { get; set; } = null!;
    }
}
