using Laboratorium3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Laboratorium3.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarService _cars;


        public CarController(ICarService carService)
        {
            _cars = carService;
        }
        public IActionResult Index()
        {
            return View(_cars.FindAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Car model)
        {
            if (ModelState.IsValid) 
            {
                _cars.Add(model);
                
                return RedirectToAction("Index");
            }
            return View();

        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            return View(_cars.FindById(id));
        }
        [HttpPost]
        public IActionResult Details(Car model)
        {
            if (ModelState.IsValid)
            {


                return RedirectToAction("Index");
            }
            return View();

        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            return View(_cars.FindById(id));
        }
        [HttpPost]
        public IActionResult Update(Car model)
        {
            if (ModelState.IsValid)
            {
                _cars.Update(model);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            return View(_cars.FindById(id));
        }
        [HttpPost]
        public IActionResult Delete(Car model)
        {
            var CarDelete = _cars.FindById(model.Id);

            if ( CarDelete != null)
            {
                _cars.DeleteById(CarDelete);
                return RedirectToAction("Index");
            }

            return NotFound(); 

        }
    }
}