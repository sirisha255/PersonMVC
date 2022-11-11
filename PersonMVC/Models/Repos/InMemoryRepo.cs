namespace PersonMVC.Models.Repos
{
    public class InMemoryRepo : IPeopleRepo
    {
        static int idCounter = 0;
        static List<People> peoplesList = new List<People>();
        public People Create(People people)
        {
            people.Id = ++idCounter;
            peoplesList.Add(people);
            return people;
        }
                
        public List<People> GetAll()
        {
            return peoplesList;
        }

        public List<People> GetByCityName(string cityName)
        {
            List<People> peopleCityName = new List<People>();   
            foreach(People pPeople in peoplesList) 
            {
                if (pPeople.CityName == cityName)
                {
                    peopleCityName.Add(pPeople);
                }

            }
            return peopleCityName;

        }

        public People GetById(int id)
        {
            People people = null;
            foreach(People people1 in peoplesList) 
            {
                if(people1.Id == id)
                {
                    people = people1;
                    break;
                }
            }
            return people;
        }

        public void Update(People people)
        {
            People originalPeople = GetById(people.Id);
            if(originalPeople != null)
            {
                originalPeople.Name = people.Name;
                originalPeople.CityName = people.CityName;
                originalPeople.PhoneNumber = people.PhoneNumber;    
            }
        }
        public void Delete(People people)
        {
            if(people != null)
            {
               peoplesList.Remove(people);
            }
        }
    }
}
