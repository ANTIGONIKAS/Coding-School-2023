using FuelStation.Blazor.Web.Shared;
using FuelStation.Model.Enums;
using FuelStation.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.WebPages;
using System.Windows.Forms;
using System.Net.Http.Json;
using Azure;
using Microsoft.VisualBasic.Logging;
using FuelStation.Blazor.Web.Client.Pages;


namespace FuelStation.Win
{
    public partial class TransactionF : Form
    {
        private List<EmployeeListDto> employee = new List<EmployeeListDto>();
        private List<CustomerListDto> customer = new  List<CustomerListDto>();
        private List<ItemListDto> items = new List<ItemListDto>();
        private TransactionListDto newTransaction = new();

        public List<TransactionListDto> transactions = new();

        public List<TransactionLineListDto> transactionLines = new();



      
        
        //HTTPCLIENT
        private readonly HttpClient httpClient = new HttpClient(new HttpClientHandler())
        {
            BaseAddress = new Uri("https://localhost:7216/")
        };

        public TransactionF()
        {

            newTransaction.Date = DateTime.Now;
       
            this.StartPosition = FormStartPosition.CenterScreen;

            InitializeComponent();
        }
        private void TransactionF_Load(object sender, EventArgs e)
        {
            SetControls();
            SetupGrids();
        }

        public void SetControls()
        {
            grvTransactions.AutoGenerateColumns = false;
            grvLines.AutoGenerateColumns = false;
            var colPayMethod = grvTransactions.Columns["colPayMethod"] as DataGridViewComboBoxColumn;
            colPayMethod.Items.Add(PayMethod.CreditCard);
            colPayMethod.Items.Add(PayMethod.Cash);

        }

        private async void SetupGrids()

            //GET TRANSACTIONS-CUSTOMER-EMPLOYEE-ITEMS
        {
            transactions = await httpClient.GetFromJsonAsync<List<TransactionListDto>>("transaction");

            // customer = await httpClient.GetFromJsonAsync<CustomerListDto>($"customer/{customer.Id}");

            //  employee = await httpClient.GetFromJsonAsync<EmployeeListDto>($"employee/{employee.Id}");

            // items = await httpClient.GetFromJsonAsync<List<ItemListDto>>("item");

            //cbPayMethod.DataSource = Enum.GetValues(typeof(PayMethod));

            bsTransactions.DataSource = transactions;
            grvTransactions.DataSource = bsTransactions;
            bsLines.DataSource = bsTransactions;

            bsLines.DataSource = transactionLines;
            bsLines.DataMember = "TransactionLines";
            grvLines.DataSource = bsLines;
            bsItems.DataSource = items;
           



            //grvLines.DataSource = bsLines;
         
        }

        private void RefreshList()
        {
            //txtDate.Refresh();
           // cbPayMethod.Refresh();
        }


        private async void btnAdd_Click(object sender, EventArgs e)
        {
            TransactionListDto transaction = (TransactionListDto)bsTransactions.Current;
            //TransactionLineListDto transaction = new();
            TransactionEditDto addNew = new TransactionEditDto();


           
            addNew.Id = transaction.Id;
            addNew.Date = transaction.Date;
            addNew.PayMethod = transaction.PayMethod;
            addNew.TotalValue = transaction.TotalValue;
            addNew.EmployeeId = transaction.EmployeeId;
            addNew.CustomerId = transaction.CustomerId;

            if (addNew.Id == 0)
            {
                //var response = await httpClient.PostAsJsonAsync("transaction", addNew);
            }
            else
            {
                var response = await httpClient.PostAsJsonAsync("transaction", addNew);
                if ((int)response.StatusCode == 200)
                {
                    MessageBox.Show("Transaction made");
                }
                else { MessageBox.Show("Error"); }
                SetupGrids();
            }
        }



        private async void btnSave_Click(object sender, EventArgs e)
        {
            TransactionListDto transaction = (TransactionListDto)bsTransactions.Current;
            TransactionEditDto selectedTransactions = new();
            selectedTransactions.Id = transaction.Id;
            selectedTransactions.EmployeeId = transaction.EmployeeId;
            selectedTransactions.CustomerId = transaction.CustomerId;
            selectedTransactions.Date = transaction.Date;
            selectedTransactions.PayMethod = transaction.PayMethod;
            selectedTransactions.TotalValue = transaction.TotalValue;


            if (selectedTransactions.Id == 0)
            {
                // CreateTransaction(transaction);
            }
            else
            {
                var response = await httpClient.PutAsJsonAsync("transaction", selectedTransactions);
                if ((int)response.StatusCode == 200)
                {
                    MessageBox.Show("Changes made");
                }
                else { MessageBox.Show("Error"); }
                SetupGrids();
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            TransactionListDto transaction = (TransactionListDto)bsTransactions.Current;
            var response = await httpClient.DeleteAsync($"transaction/{transaction.Id}");
            MessageBox.Show("Transaction Deleted");
            SetupGrids();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            LoginF loginF = new LoginF();
            loginF.Show();
            this.Close();
            
        }




     }  
    
}
