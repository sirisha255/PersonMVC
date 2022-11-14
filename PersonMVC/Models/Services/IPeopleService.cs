using PersonMVC.Models.ViewModels;

namespace PersonMVC.Models.Services
{
    public interface IPeopleService
    {
        Person Create(CreatePersonViewModel createPerson);
        List<Person> GetAll();
        Person FindById(int id);
        void Edit(int id, CreatePersonViewModel editPerson);
        void Remove(int id);
         Person LastAdded();
    
    
    }
}
