using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using FuelStation.Model;
using FuelStation.Model.Enums;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using Transaction = FuelStation.Model.Transaction;

namespace FuelStation.Win
{
    public partial class TransactionAndLineList : Form
    {
        public TransactionAndLineList()
        {
            InitializeComponent();
        }

        private void TransactionAndLineList_Load(object sender, EventArgs e)
        {
            PopulateTransactions();
            SetControls();
            GetCustomers();

            
           
        }
        private void PopulateTransactions()
        {
           List<Customer> customers = GetCustomers();

            List<Transaction> transactions = new List<Transaction>();

            Transaction trans1 = new Transaction()
            {
                Date = DateTime.Now,
                PayMethod = Model.Enums.PayMethod.CreditCard,
                TotalValue = 100,
                CustomerId= customers[0].Id
               

            };
            transactions.Add(trans1);

            Transaction trans2 = new Transaction()
            {
                Date = DateTime.Now,
                PayMethod = Model.Enums.PayMethod.Cash,
                TotalValue = 150,
                CustomerId= customers[1].Id
                

            };
            transactions.Add(trans2);

   

           
            bsTransactions.DataSource = transactions;
        }
        private List<Customer> GetCustomers()
        {
            
            Customer customer1 = new Customer()
            {
                Name = "Petros",
                Surname = "Petridis",
                CardNumber = "1324554"
            };

            Customer customer2 = new Customer()
            {
                Name = "Nikos",
                Surname = "Nikidis",
                CardNumber = "1324556"
            };
            List<Customer> customers = new List<Customer>() { customer1, customer2 };
            return customers;
            
        }

        private void SetControls()
        {
            var colPayMethod = grvTransactions.Columns["colPayMethod"] as DataGridViewComboBoxColumn;
            colPayMethod.Items.Add(PayMethod.CreditCard);
            colPayMethod.Items.Add(PayMethod.Cash);
            var colCustomer1 = grvTransactions.Columns["colCustomer"] as DataGridViewComboBoxColumn;
            colCustomer1.DataSource=GetCustomers();
            colCustomer1.DisplayMember = "Id";
            grvTransactions.AutoGenerateColumns = false;
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PopulateTransactions();
        }
    }
}
