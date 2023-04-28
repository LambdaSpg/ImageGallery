using Microsoft.EntityFrameworkCore;

namespace ImageGalleryApp.Structure;

public class ImageContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .UseMySql("server=localhost;uid=root;pwd=k0nradius;database=imagegallery")
            .EnableDetailedErrors()
            .EnableSensitiveDataLogging();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        /*
         * modelBuilder.Entity<Role>().ToTable("roles");
        modelBuilder.Entity<Client>().ToTable("clients");
        modelBuilder.Entity<Channel>().ToTable("channels");
        modelBuilder.Entity<ChannelPermissions>().ToTable("channelpermissions");
        modelBuilder.Entity<ClientRoles>().HasKey(sc => new { PermissionRoleId = sc.RoleId, PermissionClientId = sc.ClientId });
        modelBuilder.Entity<ChannelPermissions>().HasKey(sc => new { PermissionRoleId = sc.RoleId, PermissionChannelId = sc.ChannelId });

        
        modelBuilder.Entity<Channel>().Property(c => c.ChannelId)
            .ValueGeneratedOnAdd()
            .HasColumnType("integer");
        modelBuilder.Entity<Role>().Property(r => r.RoleId)
            .ValueGeneratedOnAdd()
            .HasColumnType("integer");;
        modelBuilder.Entity<Client>().Property(c => c.ClientId)
            .ValueGeneratedOnAdd()
            .HasColumnType("integer");
         */
    }
}