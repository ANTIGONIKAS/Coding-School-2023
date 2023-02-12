using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetShop.EF.Repositories;
using PetShop.Model;

namespace MVC.Controllers
{
    public class EmployeeContoller : Controller
    {
        private readonly EntityInterface<Employee> _employeeRepo;
        public EmployeeContoller(EntityInterface<Employee> employeeRepo)
        {
            _employeeRepo = employeeRepo;
        }

        // GET: EmployeeContoller

        public ActionResult Index()
        {

            var employees = _employeeRepo.GetAll();
            return View(model: employees);
        }

        // GET: EmployeeContoller/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var employee = _employeeRepo.GetById(id.Value);

            if (employee == null)
            {
                return NotFound();
            }
            return View(model: employee);


        }

        // GET: EmployeeContoller/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeContoller/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EmployeeCreateDto employee)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var dbEmployee = new Employee(employee.Name, employee.Surname, employee.EmployeeType, employee.SalaryPerMonth);


            _employeeRepo.Add(dbEmployee);
            return RedirectToAction("Index");
        }
               
    


        // GET: EmployeeContoller/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EmployeeContoller/Edit/5
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

        // GET: EmployeeContoller/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmployeeContoller/Delete/5
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
