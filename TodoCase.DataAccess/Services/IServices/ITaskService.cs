using System;
using System.Collections.Generic;
using System.Text;
using TodoCase.Core.Entities;
using TodoCase.Core.ViewModel;

namespace TodoCase.DataAccess.Services.IServices
{
    public interface ITaskService
    {
        IEnumerable<Task> GetAll();
        void Update(Task model);
        void Insert(Task model);
        void Delete(int id);
        TaskListViewModel GetTaskById(int id);
        Task GetByPersonId(int id);
    }
}
