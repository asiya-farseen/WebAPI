using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using localBusinessNewWebAPI.Models;


namespace localBusinessNewWebAPI.Data
{
    public class localBusinessNewWebAPIContext : DbContext
    {
        public localBusinessNewWebAPIContext(DbContextOptions<localBusinessNewWebAPIContext> options)
            : base(options)
        {
        }
        public DbSet<localBusinessNewWebAPI.Models.Role> Role { get; set; }

    }
}
