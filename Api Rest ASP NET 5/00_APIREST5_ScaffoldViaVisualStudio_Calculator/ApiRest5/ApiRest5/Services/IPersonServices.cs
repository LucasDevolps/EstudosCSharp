using ApiRest5.Model;
using System.Collections.Generic;

namespace ApiRest5.Services
{
    public interface IPersonServices
    {
        Person Create(Person person);

        Person FindByID(long id);

        List<Person> FindAll();

        Person Update(Person person);

        void Delete(long id);
    }
}
