using System.Collections.Generic;

namespace webApiEx.Contracts
{
    public interface IPeopleService
    {
        List<Person> GetAll();
        Person GetById(int id);
    }
}