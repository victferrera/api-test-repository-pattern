using System.Collections.Generic;
using Api.Application.Models;

namespace Api.Application.Interfaces
{
    public interface IPersonRepository
    {
        Person Save(Person person);
        Person Remove(int id);
        IEnumerable<Person> GetAll();

        Person GetPerson(int id);

        Person Update(int id, Person person);
    }
}