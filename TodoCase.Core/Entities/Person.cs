using System;
using System.Collections.Generic;
using System.Text;

namespace TodoCase.Core.Entities
{
   public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
    }
}
