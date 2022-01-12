using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TodoCase.Core.Entities;
using TodoCase.Core.ViewModel;

namespace TodoCase.DataAccess.Services.IServices
{
    public interface IPersonService
    {
        IEnumerable<Person> GetAll();
        void Update(PersonelViewModel model);
        void Insert(PersonelViewModel model);
        void Delete(int id);
        PersonelViewModel GetByPersonId(int id);
    }
}
