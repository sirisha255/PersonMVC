using PersonMVC.Models.ViewModels;

namespace PersonMVC.Models.Services
{
    public interface IPeopleService
    {
        People Create(CreatePeopleViewModel createPeople);
        List<People> GetAll();
        People FindById(int id);
        void Edit(int id, CreatePeopleViewModel editPeople);
        void Remove(int id);
         People LastAdded();
    
    
    }
}
