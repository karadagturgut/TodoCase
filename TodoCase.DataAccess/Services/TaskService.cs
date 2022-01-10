using System;
using System.Collections.Generic;
using System.Text;
using TodoCase.Core.Entities;
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

        public void Insert(Task model)
        {
            try
            {
                _uow.Task.Add(model);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(Task model)
        {
            try
            {
                _uow.Task.Update(model);
            }
            catch (Exception)
            {

                throw;
            }
           
        }
        
    }
}
