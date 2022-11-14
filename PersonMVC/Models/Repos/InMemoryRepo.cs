namespace PersonMVC.Models.Repos
{
    public class InMemoryRepo : IPeopleRepo
    {
        static int idCounter = 0;
        static List<Person> persons = new List<Person>();
        public Person Create(Person person)
        {
            person.Id = ++idCounter;
            persons.Add(person);
            return person;
        }
                
        public List<Person> GetAll()
        {
            return persons;
        }

        public List<Person> GetByCity(string city)
        {
            List<Person> personList = new List<Person>();   
            if(!string.IsNullOrEmpty(city))
            {
                persons = new List<Person>();
            }
            foreach(Person pPerson in persons) 
            {
                if (pPerson.Name == city)
                {
                    personList.Add(pPerson);
                }

            }
            return personList;

        }

        public Person GetById(int id)
        {
            Person? person = null;
            foreach(Person pPerson in persons) 
            {
                if(pPerson.Id == id)
                {
                    person = pPerson;
                    break;
                }
            }
            return person;
        }

        public void Update(Person person)
        {
            Person originalPerson = GetById(person.Id);
            if(originalPerson != null)
            {
                originalPerson.Name = person.Name;
                originalPerson.City = person.City;
                originalPerson.PhoneNumber = person.PhoneNumber;    
            }
           
        }
        public void Delete(Person person)
        {
            if (person != null)
            {
                persons.Remove(person);

            }
        }
    }
}
