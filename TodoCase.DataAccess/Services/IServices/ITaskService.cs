using System.Collections.Generic;
using TodoCase.Core.Entities;
using TodoCase.Core.Enums;
using TodoCase.Core.ViewModel;

namespace TodoCase.DataAccess.Services.IServices
{
    public interface ITaskService
    {
        IEnumerable<Task> GetAll();
        void Update(TaskViewModel model);
        void Insert(TaskViewModel model);
        void Delete(int id);
        TaskListViewModel GetTaskById(int id);
        Task GetByPersonId(int id);
        TaskStatus GetTaskStatus(int taskId);
        
    }
}
