using System;
using System.Collections.Generic;

namespace demo1.Models
{
    public partial class ServiceProvider
    {
        public int Sid { get; set; }
        public string Sname { get; set; } = null!;
        public string? Status { get; set; }
    }
}
