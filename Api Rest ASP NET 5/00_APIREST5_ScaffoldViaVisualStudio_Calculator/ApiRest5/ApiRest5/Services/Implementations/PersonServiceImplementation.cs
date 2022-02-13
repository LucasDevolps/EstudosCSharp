using ApiRest5.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ApiRest5.Services.Implementations
{
    public class PersonServiceImplementation : IPersonServices
    {

        //Mokando ID
        //Sempre pegando o próximo número do banco
        private volatile int count;

        public Person Create(Person person)
        {
            return person; 
        }

        public void Delete(long id)
        {
            //Lógica de deleção
        }

        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();

            for (int i = 1; i <= 2; i++)
            {
                Person person = MockPerson(i);
                persons.Add(person);
            }

            return persons; 
        }

        public Person FindByID(long id)
        {
            return new Person
            {
                Id = 1,
                FristName = "Person Name " + id,
                LastName = "Person LastName",
                Address = "Some Address",
                Gender = "Male"

            };
        }

        public Person Update(Person person)
        {
            return person;
        }

        private Person MockPerson(int i)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FristName = "Person Name " + i,
                LastName = "Person LastName",
                Address = "Some Address",
                Gender = "Male"

            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }
    }
}
