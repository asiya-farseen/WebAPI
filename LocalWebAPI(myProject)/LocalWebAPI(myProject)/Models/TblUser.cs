using System;
using System.Collections.Generic;

namespace LocalWebAPI_myProject_.Models
{
    public partial class TblUser
    {
        public int Id { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
    }
}
