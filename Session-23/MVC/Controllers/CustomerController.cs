using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using PetShop.EF.Repositories;
using PetShop.Model;

namespace MVC.Controllers
{
    public class CustomerController : Controller

    {
        private readonly EntityInterface<Customer> _customerRepo;
        public CustomerController(EntityInterface<Customer> customerRepo)
        {

            _customerRepo = customerRepo;
        }


        // GET: CustomerController
        public ActionResult Index()

        {       //list of customers
            var customers = _customerRepo.GetAll().ToList();
            return View(model: customers);
        }

        // GET: CustomerController/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var customer = _customerRepo.GetById(id.Value);

            if (customer == null)
            {
                return NotFound();
            }
            return View(model: customer);

        }

        // GET: CustomerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CustomerCreateDto customer)
        {


            if (!ModelState.IsValid)
            {

                return View();
            }


            var dbCustomer = new Customer(customer.Name, customer.Surname,
                customer.Phone, customer.Tin);

            _customerRepo.Add(dbCustomer);
            return RedirectToAction("Index");
        }

    

        // GET: CustomerController/Edit/5
        public ActionResult Edit(int id)
        {
            var dbCustomer = _customerRepo.GetById(id);
            if (dbCustomer == null)
            {
                return NotFound();
            }
            var viewCustomer = new CustomerEditDto();
            viewCustomer.Id = dbCustomer.Id;
            viewCustomer.Name = dbCustomer.Name;
            viewCustomer.Surname = dbCustomer.Surname;
            viewCustomer.Phone = dbCustomer.Phone;
            viewCustomer.Tin = dbCustomer.Tin;

            return View(model: dbCustomer); ;
        }

        // POST: CustomerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, CustomerEditDto customer)
        {
            if (!ModelState.IsValid)
            {

                return View();
            }
            var dbCustomer = _customerRepo.GetById(id);
            if (customer == null)
            {
                return NotFound();
            }
            dbCustomer.Name = customer.Name;
            dbCustomer.Surname = customer.Surname;
            dbCustomer.Phone = customer.Phone;
            dbCustomer.Tin = customer.Tin;

            _customerRepo.Update(id, dbCustomer);
            return RedirectToAction(nameof(Index));

        }



        // GET: CustomerController/Delete/5
        public ActionResult Delete(int id)
        {
            var dbCustomer = _customerRepo.GetById(id);
            if (dbCustomer == null)
            {
                return NotFound();
            }
            var viewCustomer = new CustomerDeleteDto();
            viewCustomer.Id = dbCustomer.Id;
            viewCustomer.Name = dbCustomer.Name;
            viewCustomer.Surname = dbCustomer.Surname;
            viewCustomer.Phone = dbCustomer.Phone;
            viewCustomer.Tin = dbCustomer.Tin;


            return View(model: viewCustomer);
        }

        // POST: CustomerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            _customerRepo.Delete(id);
            return RedirectToAction(nameof(Index));

        }
    }
           
            
            
           
        
    
}
