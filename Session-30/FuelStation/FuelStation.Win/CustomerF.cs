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
using Microsoft.VisualBasic.Logging;
using System.Xml.Linq;
using Azure;

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
        private List<CustomerListDto> customers = new();
        private CustomerListDto _customerListDto;

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


        //get
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

        private async Task CreateCustomer(CustomerEditDto customer)
        {
            HttpResponseMessage? response = null;
            response = await client.PostAsJsonAsync("customer", customer);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Customer Created successfully");
                PutCustomersToDataSource();
            }
            else
            {
                MessageBox.Show("Error Customer is not created.");
            }
        }


        private async Task UpdateCustomer(CustomerEditDto customer)
        {
            HttpResponseMessage? response = null;
            response = await client.PutAsJsonAsync("customer", customer);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Customer Updated successfully");
                PutCustomersToDataSource();
            }
            else
            {
                MessageBox.Show("Error customer is not updated.");
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
                    MessageBox.Show("Customer Deleted successfully");
                    PutCustomersToDataSource();
                }
                else
                {
                    MessageBox.Show("Error Customer is not deleted.");
                }
            }
            else
            {
                MessageBox.Show("Customer is not selected.");
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {

         
            CustomerListDto customer = (CustomerListDto)bsCustomers.Current;
            CustomerEditDto temp = new();
            temp.Id = customer.Id;
            temp.Surname = customer.Surname;
            temp.Name = customer.Name;
            temp.CardNumber=customer.CardNumber;
                if (customer.Id == 0)
                {
                    CreateCustomer(temp);

                }
                else
                {

                    UpdateCustomer(temp);
                }
            }

        
            private void btnDelete_Click(object sender, EventArgs e)
        {
        CustomerListDto customer = (CustomerListDto)bsCustomers.Current;
            DeleteCustomer(customer);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            LoginF loginF = new LoginF();
            loginF.Show();

            this.Close();

        }
    }

}