using FuelStation.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FuelStation.Blazor.Web.Client.Pages;
using FuelStation.Blazor.Web.Shared;
using FuelStation.Blazor.Web.Server.Controllers;

using System.Net.Http.Formatting;
using System.Net.Http;

using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace FuelStation.Win
{
    public partial class CustomerList : Form
    {
        public CustomerList()
        {
            InitializeComponent();
            
           

        }

        private void CustomerList_Load(object sender, EventArgs e)
        {
            //PopulateCustomers();
           // this.PopulateDataGridView();
        }

        private void btnLoadCustomers_Click(object sender, EventArgs e)
        {
            HttpClient client=new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7216");
            HttpResponseMessage response = client.GetAsync("/customer").Result;
            var customer=response.Content.ReadAsAsync<IEnumerable<CustomerListDto>>().Result;
            bsCustomers.DataSource= customer;
            grvCustomers.DataSource= bsCustomers;

        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {

           



        }



        public void PopulateCustomers()
        {
            List<Customer> customers = new List<Customer>();

            Customer c1 = new Customer()
            {
                Name = "Antigoni",
                Surname = "Kasioura",
                CardNumber = "123456789"

            };

            customers.Add(c1);

            Customer c2 = new Customer()
            {
                Name = "Anna",
                Surname = "Kasioura",
                CardNumber = "123456787"
            };
            customers.Add(c2);
            grvCustomers.AutoGenerateColumns = false;
            bsCustomers.DataSource = customers;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //PopulateCustomers();
        }

        
    }
}
