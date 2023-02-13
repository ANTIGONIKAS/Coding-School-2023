using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetShop.EF.Repositories;
using PetShop.Model;
using System.Drawing;

namespace MVC.Controllers
{
    public class PetFoodController : Controller
    {
        private readonly EntityInterface<PetFood> _petFoodRepo;
        public PetFoodController(EntityInterface<PetFood> petFoodRepo)
        {
            _petFoodRepo= petFoodRepo;
        }
    
        // GET: PetFoodController
        public ActionResult Index()
        {
            var petFoods =_petFoodRepo.GetAll();
            return View(model:petFoods);
        }

        // GET: PetFoodController/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var petFood = _petFoodRepo.GetById(id.Value);
            if (petFood == null)
            {
                return NotFound();
            }
            return View(model:petFood);
        }

        // GET: PetFoodController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PetFoodController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PetFoodCreateDto petFood)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var dbPetFood = new PetFood(petFood.AnimalType,  petFood.Price, petFood.Cost);

            _petFoodRepo.Add(dbPetFood);

            return RedirectToAction("Index");
           
        }
    

    // GET: PetFoodController/Edit/5
        public ActionResult Edit(int id)
    {
            var dbPetFood = _petFoodRepo.GetById(id);
            if (dbPetFood == null)
            {
                return NotFound();
            }
            var viewPetFood = new PetFoodEditDto();
            viewPetFood.Id = dbPetFood.Id;
            viewPetFood.AnimalType = dbPetFood.AnimalType;
            viewPetFood.Price = dbPetFood.Price;
            viewPetFood.Cost = dbPetFood.Cost;


            return View(model: dbPetFood); ;

           
    }

    // POST: PetFoodController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, PetFoodEditDto petFood)
        {
            if (!ModelState.IsValid)
            {

                return View();
            }
            var dbPetFood = _petFoodRepo.GetById(id);
            if (petFood == null)
            {
                return NotFound();
            }
            dbPetFood.AnimalType = petFood.AnimalType;
            
            dbPetFood.Price = dbPetFood.Price;
            dbPetFood.Cost = dbPetFood.Cost;

            _petFoodRepo.Update(id, dbPetFood);
            return RedirectToAction(nameof(Index));
        }

        // GET: PetFoodController/Delete/5
        public ActionResult Delete(int id)
        {
            var dbPetFood = _petFoodRepo.GetById(id);
            if (dbPetFood == null)
            {
                return NotFound();
            }
            var viewPetFood = new PetFoodDeleteDto();
            viewPetFood.Id = dbPetFood.Id;
            viewPetFood.AnimalType = dbPetFood.AnimalType;
           ;
            viewPetFood.Price = dbPetFood.Price;
            viewPetFood.Cost = dbPetFood.Cost;


            return View(model: viewPetFood);

           
        }

        // POST: PetFoodController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            _petFoodRepo.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
