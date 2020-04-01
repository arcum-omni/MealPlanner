using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MealPlanner.Models
{
    // http://www.dotnetawesome.com/2017/06/event-calendar-in-aspnet-mvc.html

    public class Calendar
    {
        [Key]
        public int EventId { get; set; }

        [Required]
        [StringLength(100)]
        public string Subject { get; set; }

        [StringLength(300)]
        public string Description { get; set; }

        public DateTime Start { get; set; }

        public DateTime? End { get; set; }

        [StringLength(10)]
        public string ThemeColor { get; set; }

        public bool IsFullDay { get; set; }
    }
}
