using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TodoCase.Core.Entities;

namespace TodoCase.DataAccess.Repository.IRepository
{
    public interface IPersonelAdressesRepository:IRepository<PersonAdresses>
    {
        IQueryable<PersonAdresses> GetByPersonId(int id);
    }
}
