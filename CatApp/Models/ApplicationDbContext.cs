
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace ChatApp.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser> 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {           
        }


        public DbSet<ChatMessage> ChatMessages { get; set; }
        public DbSet<UserFriend> UserFriends { get; set; }

        public DbSet<ChatGroup> ChatGroups { get; set; }

        public DbSet<ChatGroupMember> ChatGroupMembers { get; set; }


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);

        //    //var config = new ConfigurationBuilder().AddJsonFile("appsetting").Build();
        //    //var connectionstring = config.GetSection("constr").Value;
        //    optionsBuilder.UseSqlServer("Server = DESKTOP-MN6ULTF\\SSEXP; Database= AcademixDb; TrustServerCertificate = True; Trusted_Connection=True;");
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }

    }
}
