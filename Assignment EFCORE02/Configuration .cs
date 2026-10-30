using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_EFCORE02
{
    internal class Configuration : IEntityTypeConfiguration<Badge>
    {
        public void Configure(EntityTypeBuilder<Badge> builder)
        {
            builder.HasKey(p => p.Id);
            builder.HasOne(b => b.attendee).WithOne(a => a.badge).HasForeignKey<Badge>(b => b.AttendeeId);
        }
    }
}
