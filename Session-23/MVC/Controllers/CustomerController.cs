﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using PetShop.EF.Repositories;
using PetShop.Model;

namespace MVC.Controllers
{
    public class CustomerController : Controller

    {    private readonly EntityInterface<Customer> _customerRepo;
        public CustomerController(EntityInterface<Customer> customerRepo)
        {

               _customerRepo = customerRepo ; 
        }
       
        
        // GET: CustomerController
        public ActionResult Index()

        {       //list of customers
            var customers= _customerRepo.GetAll().ToList();
            return View(model:customers);
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
            return View(model:customer);

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


            try
            {
                if (!ModelState.IsValid)
                {
                    if (!ModelState.IsValid)
                    {
                        var errors = ModelState.SelectMany(x => x.Value.Errors.Select(z => z.Exception));
                        return View();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            var dbCustomer = new Customer(customer.Name ,customer.Surname,
                customer.Phone,customer.Tin);

            _customerRepo.Add(dbCustomer);
            return RedirectToAction("Index");
        }

        // GET: CustomerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CustomerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CustomerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}