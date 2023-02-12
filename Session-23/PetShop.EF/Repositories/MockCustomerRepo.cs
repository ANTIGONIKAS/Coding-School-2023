using PetShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.EF.Repositories
{
    public class MockCustomerRepo : EntityInterface<Customer>
    {
        private readonly List<Customer> _customers;


        public MockCustomerRepo()

        {
            _customers = new List<Customer>();

            Customer c1 = new Customer("Antigoni", "Kasioura", "6978467448", "1259878954");
            _customers.Add(c1);
            Customer c2 = new Customer("Katerina", "Papadopoyloy", "6973215789", "1253369879");
            _customers.Add(c2);
            Customer c3 = new Customer("Antonis", "Manolakos", "6931578987", "1234567891");


        }



        public void Add(Customer entity)
        {
            if (entity.Id != 0)
                throw new ArgumentException("Given entity should not have Id set", nameof(entity));

            var lastId = _customers.OrderBy(todo => todo.Id).Last().Id;
            entity.Id = ++lastId;
            _customers.Add(entity);
        }
    

        public void Delete(int id)
        {
            var foundCustomer = _customers.SingleOrDefault(todo => todo.Id == id);
            if (foundCustomer is null)
                throw new KeyNotFoundException($"Given id '{id}' was not found");

            _customers.Remove(foundCustomer);
        }

        public IList<Customer> GetAll()
        {
            return _customers;
        }

        public Customer? GetById(int id)
        {
            return _customers.SingleOrDefault(customer => customer.Id == id);
        }

        public void Update(int id, Customer entity)
        {
            var foundCustomer = _customers.SingleOrDefault(todo => todo.Id == id);
            if (foundCustomer is null)
                throw new KeyNotFoundException($"Given id '{id}' was not found");

            foundCustomer.Name = entity.Name;
            foundCustomer.Surname = entity.Surname;
            foundCustomer.Phone = entity.Phone;
            foundCustomer.Tin = entity.Tin;

        }
    }

}