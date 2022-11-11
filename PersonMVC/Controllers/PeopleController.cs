using Microsoft.AspNetCore.Mvc;
using PersonMVC.Models;
using PersonMVC.Models.Repos;
using PersonMVC.Models.Services;
using PersonMVC.Models.ViewModels;
using System;


namespace PersonMVC.Controllers
{
    public class PeopleController : Controller
    {
        IPeopleService _peopleService;

        public PeopleController()
        {
            _peopleService = new PeopleService(new InMemoryRepo());
        }
        public IActionResult People() // if needed
        {
            return View(_peopleService.GetAll());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View(new CreatePeopleViewModel());
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]

        public IActionResult Create(CreatePeopleViewModel createPeople)
        {
            if(ModelState.IsValid)
            {
                try
                {
                    _peopleService.Create(createPeople);

                }
                catch (ArgumentException exception)
                {
                    ModelState.AddModelError("People & CityName", exception.Message);
                    return View(createPeople);

                }
                return RedirectToAction(nameof(People));

            }
            return View(createPeople);
        }

        public IActionResult Details(int id)
        {
            People people = _peopleService.FindById(id);
            if(people == null)
            {
                return RedirectToAction(nameof(People));

            }
            return View(people);
        }
        public IActionResult LastPeopleArrivel()
        {
            People people = _peopleService.LastAdded();
            if(people != null)
            {
                return PartialView("_PeopleRow",people);
            }
            return NotFound();
        }
        
    }
}
