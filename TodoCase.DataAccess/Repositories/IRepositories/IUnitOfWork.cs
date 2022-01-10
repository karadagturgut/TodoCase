using System;
using System.Collections.Generic;
using System.Text;
using TodoCase.DataAccess.Repository.IRepository;

namespace TodoCase.DataAccess.Repositories.IRepositories
{
    public interface IUnitOfWork : IDisposable
    {
        IPersonRepository Person { get; }
        IPersonelAdressesRepository PersonelAddresses { get; }
        ITaskRepository Task { get; }
        IPersonelTaskRepository PersonelTask { get; }
        public void Save();

    }
}
