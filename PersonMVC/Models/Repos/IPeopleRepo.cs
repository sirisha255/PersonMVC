using System;

namespace PersonMVC.Models.Repos
{
    public interface IPeopleRepo
    {
        //crud
        //c
        People Create(People people);

        //Read
        List<People> GetAll();
        List<People> GetByCityName(string CityName);
         
        People GetById(int id);


        //U
        void Update(People people);

        //Delete
        void Delete(People people);
        //People LastAdded();
    }
}
