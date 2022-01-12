using System;
using System.Collections.Generic;
using System.Text;
using TodoCase.Core.Enums;

namespace TodoCase.Core.Entities
{
    public class PersonAdresses
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public string AdressType { get; set; }
        public string Name { get; set; }
        public int CityId { get; set; }
        public string Address { get; set; }
    }
}
