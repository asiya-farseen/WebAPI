using Microsoft.EntityFrameworkCore;

namespace assignment.Models
{


    [Keyless]
    public class Login
    {
        public string? email { get; set; }
        public string? password { get; set; }
    }
}
