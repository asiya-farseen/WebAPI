using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;


namespace LocalBussinessTestWebAPI.Models
{
    public class dataContex :DbContext

    {
        public dataContex(DbContextOptions<dataContex> options)  : base(options)
  
{
}

public DbSet<Users> Users { get; set; } = null!;
        public DbSet<serviceProviders> serviceProviders { get; set; } = null!;


    }
}

  
   
