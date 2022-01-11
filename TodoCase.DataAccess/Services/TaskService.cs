using System;
using System.Collections.Generic;
using System.Text;
using TodoCase.Core.Entities;
using TodoCase.Core.Enums;
using TodoCase.Core.ViewModel;
using TodoCase.DataAccess.Repositories.IRepositories;
using TodoCase.DataAccess.Services.IServices;

namespace TodoCase.DataAccess.Services
{
    public class TaskService : ITaskService
    {
        private readonly IUnitOfWork _uow;
        public TaskService(IUnitOfWork uow)
        {
            _uow = uow;
        }
        public void Delete(int id)
        {
            try
            {
                _uow.Task.Remove(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IEnumerable<Task> GetAll()
        {
            return _uow.Task.GetAll();
        }

        public Task GetByPersonId(int id)
        {
            var taskList = _uow.Task.TaskByPersonId(id);
            return taskList;
        }

        public TaskListViewModel GetTaskById(int id)
        {
            TaskListViewModel model = new TaskListViewModel();
            model.Task = _uow.Task.GetFirstOrDefault(x=>x.Id==id);
            model.PersonList = _uow.Person.GetAll();
            return model;
        }

        public TaskStatus GetTaskStatus(int taskId)
        {
           return _uow.PersonelTask.GetFirstOrDefault(x => x.TaskId == taskId).TaskStatus;
        }

        public void Insert(TaskViewModel model)
        {
            try
            {
                _uow.Task.Add(model.Task);
                PersonelTask personelTask = new PersonelTask { PersonelId = model.Task.PersonelId, TaskId = model.Task.Id, TaskStatus = model.TaskStatus };
                _uow.PersonelTask.Add(personelTask);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void Update(TaskViewModel model)
        {
            try
            {
                _uow.Task.Update(model.Task);
                PersonelTask personelTask = new PersonelTask{ PersonelId = model.Task.PersonelId, TaskId = model.Task.Id, TaskStatus = model.TaskStatus };
                _uow.PersonelTask.Update(personelTask);
            }
            catch (Exception)
            {

                throw;
            }
           
        }
        
    }
}
