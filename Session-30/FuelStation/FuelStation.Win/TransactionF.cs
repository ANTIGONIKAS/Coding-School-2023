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
using System.Windows.Forms;

namespace FuelStation.Win
{
    public partial class TransactionF : Form
    {
        HttpClient client = new HttpClient();

        public TransactionF()
        {
            InitializeComponent();
            client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7216/");
        }

        private void TransactionF_Load(object sender, EventArgs e)
        {
            PutTransactionsToDataSource();
            SetControls();
        }


        private async Task PutTransactionsToDataSource()
        {
            var transactions = await LoadTransactions();
            if (transactions != null)
            {
                bsTransactions.DataSource = transactions;
                grvTransactions.DataSource = bsTransactions;
            }
        }

        private void SetControls()
        {
            var colPayMethod = grvTransactions.Columns["colPayMethod"] as DataGridViewComboBoxColumn;
            colPayMethod.Items.Add(PayMethod.CreditCard);
            colPayMethod.Items.Add(PayMethod.Cash);
            var colCustomer = grvTransactions.Columns["colCustomer"] as DataGridViewComboBoxColumn;
            //colCustomer.DataSource = LoadCustomers();
            //colCustomer.DisplayMember = "Id";
            grvTransactions.AutoGenerateColumns = false;
        }

        private async Task<List<TransactionListDto>?> LoadTransactions()
        {
            var response = await client.GetAsync("transaction");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<TransactionListDto>>(content);
            }
            return null;
        }

        private async Task CreateTransaction(TransactionListDto transaction)
        {
            HttpResponseMessage? response = null;
            response = await client.PostAsJsonAsync("transaction", transaction);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Transaction Created successfully");
                PutTransactionsToDataSource();
            }
            else
            {
                MessageBox.Show("Error Transaction is not created.");
            }
        }

        private async Task UpdateTransaction(TransactionListDto transaction)
        {
            HttpResponseMessage? response = null;
            response = await client.PutAsJsonAsync("transaction", transaction);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Transaction Updated successfully");
                PutTransactionsToDataSource();
            }
            else
            {
                MessageBox.Show("Error Transaction is not updated.");
            }
        }

        private async Task DeleteTransaction(TransactionListDto? transaction)
        {
            HttpResponseMessage? response = null;

            if (transaction != null)
            {
                response = await client.DeleteAsync($"transaction/{transaction.Id}");
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Transaction Deleted successfully");
                    PutTransactionsToDataSource();
                }
                else
                {
                    MessageBox.Show("Error Transaction is not deleted.");
                }
            }
            else
            {
                MessageBox.Show("Transaction is not selected.");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            TransactionListDto transaction = (TransactionListDto)bsTransactions.Current;

            if (transaction.Id == 0)
            {
                CreateTransaction(transaction);
            }
            else
            {

                UpdateTransaction(transaction);

            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            TransactionListDto transaction = (TransactionListDto)bsTransactions.Current;
            DeleteTransaction(transaction);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
