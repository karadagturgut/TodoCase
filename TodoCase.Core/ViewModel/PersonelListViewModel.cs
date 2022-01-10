using System;
using System.Collections.Generic;
using System.Text;
using TodoCase.Core.Entities;

namespace TodoCase.Core.ViewModel
{
    public class PersonelListViewModel
    {
        public IEnumerable<Person> PersonList { get; set; }
        public IEnumerable<PersonAdresses> PersonAdresses { get; set; }
    }
}
