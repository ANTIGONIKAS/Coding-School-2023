using FuelStation.Blazor.Web.Shared;
using FuelStation.Model.Enums;
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


namespace FuelStation.Win
{
    public partial class TransactionF : Form
    {
        // DateTimePicker dtp=new DateTimePicker();
        //Rectangle _rectangle;

        public List<TransactionListDto> transactionList = new();
        private readonly HttpClient httpClient = new HttpClient(new HttpClientHandler())
        {
            BaseAddress = new Uri("https://localhost:7216/")
        };

        public TransactionF()
        {
            InitializeComponent();
        }
        private void TransactionF_Load(object sender, EventArgs e)
        {
            grvTransactions.AutoGenerateColumns = false;
            var colPayMethod = grvTransactions.Columns["colPayMethod"] as DataGridViewComboBoxColumn;
            colPayMethod.Items.Add(PayMethod.CreditCard);
            colPayMethod.Items.Add(PayMethod.Cash);
            SetupGrids();
        }

        private async void SetupGrids()
        {
            transactionList = await httpClient.GetFromJsonAsync<List<TransactionListDto>>("transaction");
            bsTransactions.DataSource = transactionList;
            grvTransactions.DataSource = bsTransactions;
        }

        private void RefreshList()
        {
            txtDate.Refresh();
            cbPayMethod.Refresh();
        }

        //private async Task CreateTransaction(TransactionListDto transaction)
        //{
        //    // transaction.Date = 

        //    transaction.PayMethod = (PayMethod)Enum.Parse(typeof(PayMethod), cbPayMethod.Text.ToString());

        //    transaction.TotalValue=decimal.Parse(txtTotalValue.Text);


        //    HttpResponseMessage? response = null;

        //    response = await client.PostAsJsonAsync("transaction", transaction);

        //    if (response.IsSuccessStatusCode)
        //    {
        //        MessageBox.Show("Transaction Created successfully");
        //        PutTransactionsToDataSource();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Error Transaction is not created.");
        //    }
        //}



        //private async Task UpdateTransaction(TransactionListDto transaction)
        //{
        //    HttpResponseMessage? response = null;
        //    response = await client.PutAsJsonAsync("transaction", transaction);
        //    if (response.IsSuccessStatusCode)
        //    {
        //        MessageBox.Show("Transaction Updated successfully");
        //        PutTransactionsToDataSource();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Error Transaction is not updated.");
        //    }
        //}

        //private async Task DeleteTransaction(TransactionListDto? transaction)
        //{
        //    HttpResponseMessage? response = null;

        //    if (transaction != null)
        //    {
        //        response = await client.DeleteAsync($"transaction/{transaction.Id}");
        //        if (response.IsSuccessStatusCode)
        //        {
        //            MessageBox.Show("Transaction Deleted successfully");
        //            SetupGrids();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Error Transaction is not deleted.");
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Transaction is not selected.");
        //    }
        //}

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            TransactionListDto transaction = (TransactionListDto)bsTransactions.Current;
            //TransactionLineListDto transaction = new();
            TransactionEditDto addNew = new TransactionEditDto();


               // var response = await httpClient.PostAsJsonAsync("transaction", addNew);
                addNew.Id= transaction.Id;
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
              

            if (selectedTransactions.Id== 0)
            {
               // CreateTransaction(transaction);
            }
            else
            {
                var response = await httpClient.PutAsJsonAsync("transaction",selectedTransactions);
                if ((int)response.StatusCode == 200) { 
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
            this.Close();
        }

      
    }
}
