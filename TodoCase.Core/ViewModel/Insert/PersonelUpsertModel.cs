using System;
using System.Collections.Generic;
using System.Text;
using TodoCase.Core.Entities;

namespace TodoCase.Core.ViewModel.Insert
{
   public class PersonelUpsertModel
    {
        public List<PersonAdresses> PersonAdresses { get; set; }
        public Person Person { get; set; }
    }
}
