using System;
using System.Collections.Generic;

namespace LocalWebAPI_myProject_.Models
{
    public partial class ServiceBooking
    {
        public int BookingId { get; set; }
        public int ServiceId { get; set; }
        public int UserId { get; set; }
        public int SproviderId { get; set; }
        public string Description { get; set; } = null!;
        public string Status { get; set; } = null!;
        public DateTime Date { get; set; }

        public virtual Service Service { get; set; } = null!;
        public virtual Sprovider Sprovider { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
