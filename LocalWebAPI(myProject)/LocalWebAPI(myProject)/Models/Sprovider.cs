using System;
using System.Collections.Generic;

namespace LocalWebAPI_myProject_.Models
{
    public partial class Sprovider
    {
        public Sprovider()
        {
            ServiceBookings = new HashSet<ServiceBooking>();
        }

        public int SprovidersId { get; set; }
        public int ServiceId { get; set; }
        public int UserId { get; set; }
        public string Status { get; set; } = null!;
        public DateTime Date { get; set; }

        public virtual Service Service { get; set; } = null!;
        public virtual User User { get; set; } = null!;
        public virtual ICollection<ServiceBooking> ServiceBookings { get; set; }
    }
}
