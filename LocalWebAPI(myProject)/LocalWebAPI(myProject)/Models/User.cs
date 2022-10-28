using System;
using System.Collections.Generic;

namespace LocalWebAPI_myProject_.Models
{
    public partial class User
    {
        public User()
        {
            ServiceBookings = new HashSet<ServiceBooking>();
            Sproviders = new HashSet<Sprovider>();
        }

        public int UserId { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public long Mobile { get; set; }
        public string Address { get; set; } = null!;
        public int ZipCode { get; set; }
        public string City { get; set; } = null!;
        public string Location { get; set; } = null!;
        public string Password { get; set; } = null!;
        public int? RoleId { get; set; }

        public virtual Role? Role { get; set; }
        public virtual ICollection<ServiceBooking> ServiceBookings { get; set; }
        public virtual ICollection<Sprovider> Sproviders { get; set; }
    }
}
