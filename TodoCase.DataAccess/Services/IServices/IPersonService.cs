using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TodoCase.Core.Entities;
using TodoCase.Core.ViewModel;
using TodoCase.Core.ViewModel.Insert;

namespace TodoCase.DataAccess.Services.IServices
{
    public interface IPersonService
    {
        IEnumerable<Person> GetAll();
        void Update(PersonelUpsertModel model);
        void Insert(PersonelViewModel model);
        void Delete(int id);
        PersonelUpsertModel GetByPersonId(int id);
        PersonAdresses GetAddressValuesByAddressId(int id);
    }
}
