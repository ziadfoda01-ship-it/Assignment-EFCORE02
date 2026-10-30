//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Collections.Generic;

//namespace Assignment_EFCORE02
//{
//    public class addDbContexte : DbContext
//    {
//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            optionsBuilder.UseSqlServer("Server=ZIAD\\ZIAD; Database=AssignmentEFCORE02; Trusted_Connection=True; TrustServerCertificate=True;"); 
//        }
//       public DbSet<Orgnizer> orgnizers { get; set; }
//       public DbSet<OrganizerProfile>  organizerProfiles { get; set; }
//       public DbSet<Event>  events { get; set; }
//       public DbSet<Attendee>  attendees { get; set; }
//       public DbSet<Badge>  badges { get; set; }
//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            modelBuilder.Entity<OrganizerProfile>().HasOne(p => p.Orgnizer)
//                .WithOne(o => o.organizerProfile).HasForeignKey<OrganizerProfile>(o => o.OrganizerId);
//            modelBuilder.Entity<Event>().HasOne(o => o.Orgnizer).WithMany(o => o.Events).HasForeignKey(e => e.OrgnizerId);
//        }

//    }
//}
