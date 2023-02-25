using FuelStation.Blazor.Web.Shared;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http.Json;

namespace FuelStation.Win
{
    public partial class CustomerF : Form
    {
        HttpClient client = new HttpClient();
        public CustomerF()
        {
            InitializeComponent();
            client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7216/");
        }

        private void CustomerF_Load(object sender, EventArgs e)
        {
            PutCustomersToDataSource();
        }

        private async Task PutCustomersToDataSource()
        {
            var customers = await LoadCustomers();
            if (customers != null)
            {
                bsCustomers.DataSource = customers;
                grvCustomers.DataSource = bsCustomers;
            }
        }

        private async Task<List<CustomerListDto>?> LoadCustomers()
        {
            var response = await client.GetAsync("customer");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<CustomerListDto>>(content);
            }
            return null;
        }

        private async Task CreateCustomer(CustomerListDto customer)
        {
            HttpResponseMessage? response = null;
            response = await client.PostAsJsonAsync("customer", customer);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Customer Created successfully!");
                 PutCustomersToDataSource();
            }
            else
            {
                MessageBox.Show("ERROR Creating customer.");
            }
        }


        private async Task UpdateCustomer(CustomerListDto customer)
        {
            HttpResponseMessage? response = null;
            response = await client.PutAsJsonAsync("customer", customer);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Customer Updated successfully!");
                PutCustomersToDataSource();
            }
            else
            {
                MessageBox.Show("ERROR Updating customer.");
            }
        }

        private async Task DeleteCustomer(CustomerListDto? customer)
        {
            HttpResponseMessage? response = null;

            if (customer != null)
            {
                response = await client.DeleteAsync($"customer/{customer.Id}");
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Customer Deleted successfully!");
                    PutCustomersToDataSource();
                }
                else
                {
                    MessageBox.Show("ERROR Deleting customer.");
                }
            }
            else
            {
                MessageBox.Show("Customer not selected.");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CustomerListDto customer = (CustomerListDto)bsCustomers.Current;

            if (customer.Id ==0)
            {
                CreateCustomer(customer);
            }
            else
            {

                UpdateCustomer(customer);
               
            }
        }
    

        private void btnDelete_Click(object sender, EventArgs e)
        {
        CustomerListDto customer = (CustomerListDto)bsCustomers.Current;
            DeleteCustomer(customer);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }

}