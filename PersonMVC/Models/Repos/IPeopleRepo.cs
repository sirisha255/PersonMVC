using System;

namespace PersonMVC.Models.Repos
{
    public interface IPeopleRepo
    {
        //crud
        //c
        Person Create(Person person);

        //Read
        List<Person> GetAll();
        List<Person> GetByCity(string City);
         
        Person GetById(int id);


        //U
        void Update(Person person);

        //Delete
        void Delete(Person person);
        //People LastAdded();
    }
}
