using System;
using System.Collections.Generic;
using System.Text;
using TodoCase.Core.Entities;

namespace TodoCase.DataAccess.Repository.IRepository
{
    public interface ITaskRepository : IRepository<Task>
    {
        List<Task> TaskByPersonId(int id);
    }
}
