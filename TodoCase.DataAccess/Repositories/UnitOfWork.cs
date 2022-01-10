using System;
using System.Collections.Generic;
using System.Text;
using TodoCase.DataAccess.Data;
using TodoCase.DataAccess.Repositories.IRepositories;
using TodoCase.DataAccess.Repository;
using TodoCase.DataAccess.Repository.IRepository;

namespace TodoCase.DataAccess.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public IPersonRepository Person { get; private set; }

        public IPersonelAdressesRepository PersonelAddresses { get; private set; }

        public ITaskRepository Task { get; private set; }

        public IPersonelTaskRepository PersonelTask { get; private set; }
        private readonly ApplicationDbContext _db;

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Person = new PersonRepository(_db);
            PersonelAddresses = new PersonelAdressesRepository(_db);
            PersonelTask = new PersonelTaskRepository(_db);
            Task = new TaskRepository(_db);
        }
        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
