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
    public class TaskRepository : Repository<Task> ,ITaskRepository
    {
        private readonly ApplicationDbContext _db;

        public TaskRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public List<Task> TaskByPersonId(int id)
        {
            var value = _db.Task.Where(x => x.PersonelId == id).ToList();
            return value;
        }
    }
}
