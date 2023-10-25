using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace MessageBoardApi.Models
{
  public class MessageBoardApiContext : IdentityDbContext<ApplicationUser>
  {
    public DbSet<Message> Messages { get; set; }
    public DbSet<Group> Groups { get; set; }
    // public DbSet<ApplicationUser> Users { get; set; }
    public DbSet<GroupUser> GroupUsers { get; set; }

    public MessageBoardApiContext(DbContextOptions<MessageBoardApiContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Group>()
        .HasData(
          new Group { GroupId = 1, Name = "Spider-Man" },
          new Group { GroupId = 2, Name = "Witcher" },
          new Group { GroupId = 3, Name = "Costumes" }
        );

      builder.Entity<Message>()
        .HasData(
          new Message { MessageId = 1, Text = "This new Spider-Man game looks awesome!", GroupId = 1, UserId = "abc", Date = new DateTime(2022, 12, 08, 8, 15, 0) },
          new Message { MessageId = 2, Text = "What did ya'll get for candy? I got rocks.", GroupId = 3, UserId = "sda", Date = new DateTime(2023, 3, 21, 6, 30, 0) },
          new Message { MessageId = 3, Text = "I hate Ciri!", GroupId = 2, UserId = "frg", Date = new DateTime(2020, 5, 13, 8, 11, 0) }
        );

      var hasher = new PasswordHasher<IdentityUser>();

      builder.Entity<ApplicationUser>()
        .HasData(
          new ApplicationUser { Id = "sda", UserName = "Joey", PasswordHash = hasher.HashPassword(null, "test"), Email = "joey@test.com", NormalizedEmail = "JOEY@TEST.COM" },
          new ApplicationUser { Id = "abc", UserName = "Richard", PasswordHash = hasher.HashPassword(null, "test"), Email = "richard@test.com", NormalizedEmail = "RICHARD@TEST.COM" },
          new ApplicationUser { Id = "frg", UserName = "Onur", PasswordHash = hasher.HashPassword(null, "test"), Email = "onur@test.com", NormalizedEmail = "ONUR@TEST.COM" }
        );

      builder.Entity<GroupUser>()
        .HasData(
          new GroupUser { GroupUserId = 1, UserId = "abc", GroupId = 1 },
          new GroupUser { GroupUserId = 2, UserId = "sda", GroupId = 3 },
          new GroupUser { GroupUserId = 3, UserId = "frg", GroupId = 2 },
          new GroupUser { GroupUserId = 4, UserId = "abc", GroupId = 2 },
          new GroupUser { GroupUserId = 5, UserId = "sda", GroupId = 2 }
        );

      base.OnModelCreating(builder);
    }

  }
}