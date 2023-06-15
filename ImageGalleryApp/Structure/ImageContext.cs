using System;
using ImageGalleryApp.Models;
using Microsoft.EntityFrameworkCore;
using MySql.EntityFrameworkCore;

namespace ImageGalleryApp.Structure;

public class ImageContext : DbContext
{
    public DbSet<User> Users => Set<User>();
    public DbSet<Post> Posts => Set<Post>();
    public DbSet<Pool> Pools => Set<Pool>();
    public DbSet<Tag> Tags => Set<Tag>();
    public DbSet<PostTags> PostTags => Set<PostTags>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder 
            .UseMySQL("server=localhost;uid=root;pwd=k0nradius;database=imagegallery")
            .EnableDetailedErrors()
            .EnableSensitiveDataLogging()
            .UseLazyLoadingProxies()
            .LogTo(Console.WriteLine);
    }

    
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<PostTags>().HasKey(sc => new { TagId = sc.TagId, PostId = sc.PostId });


        modelBuilder.Entity<Post>().Property(c => c.Id)
            .ValueGeneratedOnAdd();

        /*modelBuilder.Entity<Post>()
            .HasOne(e => e.Author)
            .WithMany()
            .HasForeignKey(x => x.AuthorId);

        modelBuilder.Entity<Tag>()
            .HasOne(e => e.Implies)
            .WithMany()
            .HasForeignKey(x => x.ImpliesId);
*/
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