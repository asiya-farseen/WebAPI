using System;
using System.Collections.Generic;

namespace LocalWebAPI_myProject_.Models
{
    public partial class Service
    {
        public Service()
        {
            ServiceBookings = new HashSet<ServiceBooking>();
            Sproviders = new HashSet<Sprovider>();
        }

        public int ServiceId { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;

        public virtual ICollection<ServiceBooking> ServiceBookings { get; set; }
        public virtual ICollection<Sprovider> Sproviders { get; set; }
    }
}
