using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using New.Areas.Identity.Data;

namespace New.Areas.Identity.Data;

public class ApplicationDbContext : IdentityDbContext<ApplictionUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
     
        builder.ApplyConfiguration(new ApplicationUserEntityConfiguration());
    }
}
public class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<ApplictionUser>
{ 
       

    public void Configure(EntityTypeBuilder<ApplictionUser> builder)
    {
        builder.Property(u => u.FirstName).HasMaxLength(250);
        builder.Property(u => u.LastName).HasMaxLength(255);
    }
}

