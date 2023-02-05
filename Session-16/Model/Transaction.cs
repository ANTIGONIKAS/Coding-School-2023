using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Model;

public class Transaction
{


    //PROPERTIES

    public Guid TransactionID { get; set; } //PK

    public DateTime TransactionDate { get; set; }

    public int PetFoodQty { get; set; }
    public double PetFoodPrice { get; set; }
    public double PetPrice { get; set; }
    public double TotalPrice { get; set; }




    //Relations

    public Customer Customer { get; set; } = null!;
    public Guid CustomerID { get; set; }  //FK
    public Pet Pet { get; set; } = null!;
    public Guid PetID { get; set; }
    public PetFood PetFood { get; set; } = null!;
    public Guid PetFoodID { get; set; }
    public Employee Employee { get; set; } = null!;
    public Guid EmployeeID { get; set; }

    public List<TransactionLine> TransactionLines { get; set; } = null!;
    public Guid TransactionLineID { get; set; }


    public Transaction()
    {
        TransactionID = Guid.NewGuid();
        TransactionDate = DateTime.Now;
        TransactionLines = new List<TransactionLine>();
    }

    public Transaction(Guid transactionID, DateTime transactionDate, double petPrice, int petFoodQty, double petFoodPrice,
        double totalPrice, Pet pet, Guid petID, Customer customer, Guid customerID, Employee employee, Guid employeeID)
    {
        TransactionID = transactionID;
        TransactionDate = transactionDate;
        PetPrice = petPrice;
        PetFoodQty = petFoodQty;
        PetFoodPrice = petFoodPrice;
        TotalPrice = totalPrice;
        Pet = pet;
        PetID = petID;
        Customer = customer;
        CustomerID = customerID;
        Employee = employee;
        EmployeeID = employeeID;
    }


}



