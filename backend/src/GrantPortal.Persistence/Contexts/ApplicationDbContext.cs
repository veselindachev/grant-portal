using GrantPortal.Domain.Entities.Applications;
using GrantPortal.Domain.Entities.Attachments;
using GrantPortal.Domain.Entities.Grants;
using GrantPortal.Domain.Entities.Notifications;
using GrantPortal.Domain.Entities.Reviews;
using GrantPortal.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;

namespace GrantPortal.Persistence.Contexts;

public class ApplicationDbContext : DbContext
{
    public DbSet<User> Users => Set<User>();
    public DbSet<GrantProgram> GrantPrograms => Set<GrantProgram>();
    public DbSet<Application> Applications => Set<Application>();
    public DbSet<ApplicationAnswer> ApplicationAnswers => Set<ApplicationAnswer>();
    public DbSet<ApplicationAttachment> ApplicationAttachments => Set<ApplicationAttachment>();
    public DbSet<Review> Reviews => Set<Review>();
    public DbSet<Notification> Notifications => Set<Notification>();

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // TODO: Apply entity configurations and constraints.
        base.OnModelCreating(modelBuilder);
    }
}
