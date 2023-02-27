using Azure;
using FuelStation.Blazor.Web.Shared;
using FuelStation.Model;
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
    public partial class TransactionLineF : Form
    {
        HttpClient client = new HttpClient();
        public TransactionLineF()
        {
            InitializeComponent();
            client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7216/");
        }

        private void TransactionLineF_Load(object sender, EventArgs e)
        {
            PutTransactionLinesToDataSource();
          
        }

       


        private async Task PutTransactionLinesToDataSource()
        {
            var transactionLines = await LoadTransactionLines();
            if (transactionLines != null)
            {
                bsLines.DataSource = transactionLines;
                grvLines.DataSource = bsLines;
               
            }
        }

        private async Task<List<TransactionLineListDto>?> LoadTransactionLines()
        {
            var response = await client.GetAsync("transactionLine");

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<TransactionLineListDto>>(content);
            }
            return null;
        }

        private async Task CreateTransactionLine(TransactionLineListDto transactionLine)
        {
            


            HttpResponseMessage? response = null;

            response = await client.PostAsJsonAsync("transaction", transactionLine);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("TransactionLine Created successfully");
                PutTransactionLinesToDataSource();
            }
            else
            {
                MessageBox.Show("Error TransactionLine is not created.");
            }
        }

        private async Task UpdateTransactionLine(TransactionLineListDto transactionLine)
        {
            HttpResponseMessage? response = null;
            response = await client.PutAsJsonAsync("transactionLine", transactionLine);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Transaction Updated successfully");
                PutTransactionLinesToDataSource();
            }
            else
            {
                MessageBox.Show("Error TransactionLine is not updated.");
            }
        }

        private async Task DeleteTransactionLine(TransactionLineListDto? transactionLine)
        {
            HttpResponseMessage? response = null;

            if (transactionLine != null)
            {
                response = await client.DeleteAsync($"transactionLine/{transactionLine.Id}");
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Transaction Deleted successfully");
                    PutTransactionLinesToDataSource();
                }
                else
                {
                    MessageBox.Show("Error TransactionLine is not deleted.");
                }
            }
            else
            {
                MessageBox.Show("TransactionLine is not selected.");
            }
        }





        private void btnSave_Click(object sender, EventArgs e)
        {
            TransactionLineListDto transactionLine = (TransactionLineListDto)bsLines.Current;

            if (transactionLine==null)
            {
                CreateTransactionLine(transactionLine);
            }
            else
            {

                UpdateTransactionLine(transactionLine);

            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            TransactionLineListDto transactionLine = (TransactionLineListDto)bsLines.Current;
            DeleteTransactionLine(transactionLine);



        }
       

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        //not used
        private void lblTransactionLines_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
