using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetShop.EF.Repositories;
using PetShop.Model;

namespace MVC.Controllers
{
    public class PetController : Controller
    {
        // GET: PetController
        public readonly EntityInterface<Pet> _petRepo;
        public PetController(EntityInterface<Pet> petRepo )
        {
            _petRepo= petRepo;
        }
        public ActionResult Index()
        {
            var pets = _petRepo.GetAll();

            return View(model:pets);
        }

        // GET: PetController/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var pet= _petRepo.GetById(id.Value);

            if (pet == null)
            {
                return NotFound();
            }
            return View(model: pet);
            
        }

        // GET: PetController/Create
        public ActionResult Create()
        {

            
            return View();
        }

        // POST: PetController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PetCreateDto pet)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var dbPet = new Pet(pet.Breed, pet.AnimalType, pet.PetStatus, pet.Price, pet.Cost);
            _petRepo.Add(dbPet);
            return RedirectToAction("Index");
            }
        

        // GET: PetController/Edit/5
        public ActionResult Edit(int id)
        {
            var dbPet = _petRepo.GetById(id);
            if (dbPet == null)
            {
                return NotFound();
            }
            var viewPet = new PetEditDto();
            viewPet.Id = dbPet.Id;
            viewPet.Breed = dbPet.Breed;
            viewPet.AnimalType = dbPet.AnimalType;
            viewPet.PetStatus = dbPet.PetStatus;
            viewPet.Price = dbPet.Price;
            viewPet.Cost = dbPet.Cost;


            return View(model: dbPet); 
            
        }

        // POST: PetController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, PetEditDto pet)
        {
            if (!ModelState.IsValid)
            {

                return View();
            }
            var dbPet = _petRepo.GetById(id);
            if (pet == null)
            {
                return NotFound();
            }
            dbPet.Breed = pet.Breed;
            dbPet.AnimalType=dbPet.AnimalType;
            dbPet.PetStatus=dbPet.PetStatus;
            dbPet.Price=dbPet.Price;
            dbPet.Cost=dbPet.Cost;

            _petRepo.Update(id, dbPet);
            return RedirectToAction(nameof(Index));
        }

        // GET: PetController/Delete/5
        public ActionResult Delete(int id)
        {
            var dbPet = _petRepo.GetById(id);
            if (dbPet == null)
            {
                return NotFound();
            }
            var viewPet = new PetDeleteDto();
            viewPet.Id = dbPet.Id;
            viewPet.Breed = dbPet.Breed;
            viewPet.AnimalType=dbPet.AnimalType;
            viewPet.PetStatus = dbPet.PetStatus;
            viewPet.Price = dbPet.Price;
            viewPet.Cost=dbPet.Cost;


            return View(model: viewPet);
        }

        // POST: PetController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            _petRepo.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
