using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TodoCase.Core.Entities;
using TodoCase.Core.ViewModel;
using TodoCase.DataAccess.Repositories.IRepositories;
using TodoCase.DataAccess.Repository.IRepository;
using TodoCase.DataAccess.Services.IServices;

namespace TodoCase.DataAccess.Services
{
    public class PersonelService : IPersonService
    {
        private readonly IUnitOfWork _uow;
        public PersonelService(IUnitOfWork uow)
        {
            _uow = uow;
        }
        public void Delete(int id)
        {
            try
            {
                _uow.Person.Remove(id);
            }
            catch (Exception)
            {

                throw;
            }

        }

        public PersonelListViewModel GetAll()
        {
            PersonelListViewModel model = new PersonelListViewModel();
            model.PersonList = _uow.Person.GetAll();
            model.PersonAdresses = _uow.PersonelAddresses.GetAll();
            return model;

        }

        public PersonelViewModel GetByPersonId(int id)
        {
            PersonelViewModel model = new PersonelViewModel();
            model.Person = _uow.Person.GetFirstOrDefault(x=>x.Id==id);
            model.Adresses = _uow.PersonelAddresses.GetByPersonId(id);
            return model;
        }

        public void Insert(PersonelViewModel model)
        {
            try
            {
                var person = model.Person;
                _uow.Person.Add(person);

                foreach (var item in model.Adresses)
                {
                    _uow.PersonelAddresses.Add(item);
                }
                _uow.Save();
            }
            catch (Exception)
            {

                throw;
            }

        }
        public void Update(PersonelViewModel model)
        {
            var person = model.Person;
            _uow.Person.Update(person);
            foreach (var item in model.Adresses)
            {
                _uow.PersonelAddresses.Update(item);
            }
            _uow.Save();

        }
    }
}
