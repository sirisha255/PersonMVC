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
        public People Create(CreatePeopleViewModel createPeople)
        {
            if (string.IsNullOrEmpty(createPeople.Name) || string.IsNullOrWhiteSpace(createPeople.CityName))//|| int.Parse(createPeople.PhoneNumber))
            {
                throw new ArgumentException("Name,PhoneNumber,CityName not allowed whitespace");
            }
                    
             People people = new People()
            {
                Name = createPeople.Name,
                PhoneNumber = createPeople.PhoneNumber,
                CityName = createPeople.CityName

            };
            people = _peopleRepo.Create(people);
            return people;

        }

       

        public People FindById(int id)
        {
            return _peopleRepo.GetById(id);
        }

        public List<People> GetAll()
        {
            return _peopleRepo.GetAll();
        }
        //public List<People> FindByCityName(string cityname) => _peopleRepo.GetByCityName(cityname);
        public void Edit(int id, CreatePeopleViewModel editPeople)
        {
            throw new NotImplementedException();
        }
        public void Remove(int id)
        {
            throw new NotImplementedException();
        }
        public People? LastAdded()
        {
            List<People> people = _peopleRepo.GetAll();
            if(people.Count <1)
            {
                return null;
            }
       
         return people.Last();
        }

       
    }
}
