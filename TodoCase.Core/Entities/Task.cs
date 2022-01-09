using System;
using System.Collections.Generic;
using System.Text;

namespace TodoCase.Core.Entities
{
   public class Task
    {
        public int Id { get; set; }
        public int PersonelId { get; set; }
        public string Description { get; set; }
        public DateTime DeadlineDate { get; set; }
    }
}
