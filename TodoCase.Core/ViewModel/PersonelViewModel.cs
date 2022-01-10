using System;
using System.Collections.Generic;
using System.Text;
using TodoCase.Core.Entities;

namespace TodoCase.Core.ViewModel
{
   public class PersonelViewModel
    {
        public Person Person { get; set; }
        public IEnumerable<PersonAdresses> Adresses { get; set; }
    }
}
