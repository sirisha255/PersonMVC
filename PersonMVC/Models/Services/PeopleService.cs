using PersonMVC.Models.Repos;
using PersonMVC.Models.ViewModels;

namespace PersonMVC.Models.Services
{
    public class PeopleService : IPeopleService
    {
        IPeopleRepo _peopleRepo;
        public PeopleService(IPeopleRepo peopleRepo)
        {
            _peopleRepo = peopleRepo;
        }
        public Person Create(CreatePersonViewModel createPerson)
        {
            if (string.IsNullOrEmpty(createPerson.Name) || string.IsNullOrWhiteSpace(createPerson.City) || string.IsNullOrWhiteSpace(createPerson.PhoneNumber))
            {
                throw new ArgumentException("Name,PhoneNumber,City not allowed whitespace");
            }
                    
             Person person = new Person()
            {
                Name = createPerson.Name,
                PhoneNumber = createPerson.PhoneNumber,
                City = createPerson.City

            };
            person = _peopleRepo.Create(person);
            return person;

        }

       

        public Person FindById(int id)
        {
            return _peopleRepo.GetById(id);
        }

        public List<Person> GetAll()
        {
            return _peopleRepo.GetAll();
        }
       
        public void Edit(int id, CreatePersonViewModel editPerson)
        {
            throw new NotImplementedException();
        }
        public void Remove(int id)
        {
            throw new NotImplementedException();
        }
        public Person LastAdded()
        {
            List<Person> person = _peopleRepo.GetAll();
            if(person.Count <1)
            {
                return null;
            }
       
         return person.Last();
        }

       
    }
}
