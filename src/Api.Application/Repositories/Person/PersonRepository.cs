using System.Collections.Generic;
using Api.Application.Data.Context;
using Api.Application.Interfaces;
using Api.Application.Models;
using System.Linq;

namespace Api.Application.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        public AppDbContext _context;
        public IUnitOfWork _uow;
        public PersonRepository(AppDbContext context, IUnitOfWork uow)
        {
            _context = context;
            _uow = uow;
        }
        public IEnumerable<Models.Person> GetAll()
        {
            var persons = _context.Persons.ToList();
            return persons;
        }

        public Models.Person Remove(int id)
        {
            try
            {
                var person = GetPerson(id);
                _context.Remove(person);
                _uow.Commit();
                return person;
            }
            catch
            {
                
                return null;
            }  
        }

        public Person Save(Person person)
        {
            try
            {
                _context.Add(person);
                _uow.Commit();
                return person;
            }
            catch
            {
                return null;
            }
        }

        public Person GetPerson(int id)
        {
            var person = _context.Persons.SingleOrDefault(p => p.Id == id);
            return person;
        }

        public Person Update(int id, Person person)
        {
            try
            {
                var result = GetPerson(id);
                result.Name = person.Name;
                result.BirthDate = person.BirthDate;
                result.Country = person.Country;
                _context.Persons.Update(result);
                _uow.Commit();
                return result;
            }
            catch
            {
                return null;
            }
        }
    }
}