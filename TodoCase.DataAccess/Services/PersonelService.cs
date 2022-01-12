using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TodoCase.Core.Entities;
using TodoCase.Core.ViewModel;
using TodoCase.Core.ViewModel.Insert;
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

        public IEnumerable<Person> GetAll()
        {
            var model = _uow.Person.GetAll();
            return model;

        }
        public PersonAdresses GetAddressValuesByAddressId(int id)
        {
            var model = _uow.PersonelAddresses.GetFirstOrDefault(x => x.Id == id);
            return model;
        }
        public PersonelUpdateModel GetByPersonId(int id)
        {
            PersonelUpdateModel model = new PersonelUpdateModel();
            model.Person = _uow.Person.GetFirstOrDefault(x => x.Id == id);
            model.PersonAdresses = _uow.PersonelAddresses.GetByPersonId(id).ToList();
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
        public void Update(PersonelUpdateModel model)
        {
            var person = model.Person;
            _uow.Person.Update(person);
            foreach (var item in model.PersonAdresses)
            {
                _uow.PersonelAddresses.Update(item);
            }
            _uow.Save();

        }
    }
}
