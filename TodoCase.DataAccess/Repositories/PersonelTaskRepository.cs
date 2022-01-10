using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using TodoCase.Core.Entities;
using TodoCase.DataAccess.Data;
using TodoCase.DataAccess.Repositories;
using TodoCase.DataAccess.Repository.IRepository;

namespace TodoCase.DataAccess.Repository
{
    class PersonelTaskRepository : Repository<PersonelTask> , IPersonelTaskRepository
    {
        private readonly ApplicationDbContext _db; 
        public PersonelTaskRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
     
    }
}
