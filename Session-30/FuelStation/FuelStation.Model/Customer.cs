using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Model
{
    public class Customer 
    {

        public Customer(string name, string surname, string cardNumber)
        {
            
            Name = name;
            Surname = surname;
            CardNumber = cardNumber;

            Transactions = new List<Transaction>();

        }
        public Customer()
        {

        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CardNumber { get; set; }


        //Relations
        public List<Transaction> Transactions { get; set; } = new List<Transaction>();

        //public void ShowDialog()
        //{
           
        //}
    }
}
