using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_EFCORE02
{
    public class Badge
    {
        [Key]
        public int Id { get; set; }
       
        public int BadgeNumber  { get; set; }
        public DateTime IssueDate  { get; set; }
        public string Tier { get; set; }
        public int AttendeeId { get; set; }
        public Attendee attendee { get; set; }

    }
}
