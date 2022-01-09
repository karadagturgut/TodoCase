using System;
using System.Collections.Generic;
using System.Text;

namespace TodoCase.Core.Entities
{
    public class PersonelTask
    {
        public int Id { get; set; }
        public int PersonelId { get; set; }
        public int TaskId { get; set; }
        public int TaskStatus { get; set; }
    }
}
