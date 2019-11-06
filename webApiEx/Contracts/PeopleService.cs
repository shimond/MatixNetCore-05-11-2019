using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webApiEx.Contracts
{
    public class PeopleService : IPeopleService
    {
        private static List<Person> _people = new List<Person>();
        private ILogger<PeopleService> _logger;

        public List<Person> GetAll()
        {
            return _people;
        }

        public Person GetById(int id)
        {
            return _people.FirstOrDefault(x => x.Id == id);
        }

        public PeopleService(ILogger<PeopleService> logger)
        {
            _logger = logger;
        }
        static PeopleService()
        {
            for (int i = 1; i < 10; i++)
            {
                _people.Add(new Person
                {
                    Id = i,
                    Name = "Name" + i,
                    Birthdate = DateTime.Today.AddDays(-1 * i),
                    Email = $"Name{i}@gmail.com"
                });
            }
        }

    }


}
