using FuelStation.Blazor.Web.Shared;
using FuelStation.Model.Enums;
using Microsoft.VisualBasic.Logging;
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
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace FuelStation.Win
{
    public partial class ItemF : Form
    {
        HttpClient client = new HttpClient();


        public ItemF()
        {
            InitializeComponent();
            client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7216/");
        }


        private void ItemF_Load(object sender, EventArgs e)
        {
            PutItemsToDataSource();
            SetControls();

        }

      

        private async Task PutItemsToDataSource()
        {
            var items = await LoadItems();
            if (items != null)
            {
                bsItems.DataSource = items;
                grvItems.DataSource = bsItems;
            }
        }

        //load items from database
        private async Task<List<ItemListDto>?> LoadItems()
        {
            ItemListDto itemListDto = new();
           


            var response = await client.GetAsync("item");

            txtDes.Text = itemListDto.Description;

            txtPrice.Text = itemListDto.Price.ToString();
            txtCost.Text = itemListDto.Cost.ToString();
            cbItemType.DataSource = Enum.GetValues(typeof(ItemType));

            //to refresh list with new item created

            RefreshList();

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<ItemListDto>>(content);
            }
            return null;
        }


        private void RefreshList()
        {
            txtCode.Refresh();
            txtDes.Refresh();
            txtCost.Refresh();
            txtPrice.Refresh();
            cbItemType.Refresh();
        }
            //method create
            private async Task CreateItem(ItemListDto item)
        {
            item.Code = txtCode.Text;
            item.Description = txtDes.Text;

            item.Price = decimal.Parse(txtPrice.Text);
            item.Cost = decimal.Parse(txtCost.Text);
            item.ItemType = (ItemType)Enum.Parse(typeof(ItemType), cbItemType.Text.ToString());

            HttpResponseMessage? response = null;
            response = await client.PostAsJsonAsync("item", item);
           


            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Item Created successfully");
                
                PutItemsToDataSource();

            }
            else
            {
                MessageBox.Show("Error Item is not Created.");
            }
        }

        //method update
        private async Task UpdateItem(ItemListDto item)
        {
            item.Code = txtCode.Text;
            item.Description = txtDes.Text;

            item.Price = decimal.Parse(txtPrice.Text);
            item.Cost = decimal.Parse(txtCost.Text);
            item.ItemType = (ItemType)Enum.Parse(typeof(ItemType), cbItemType.Text.ToString());

            HttpResponseMessage? response = null;
            response = await client.PutAsJsonAsync("item", item);

            SetControls();

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Item Updated successfully");
               
                PutItemsToDataSource();
            }
            else
            {
                MessageBox.Show("Error Item is not updated.");
            }
        }
        //method delete
        private async Task DeleteItem(ItemListDto? item)
        {
            HttpResponseMessage? response = null;

            if (item != null)
            {
                response = await client.DeleteAsync($"item/{item.Id}");
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Item deleted successfully");
                    PutItemsToDataSource();
                }
                else
                {
                    MessageBox.Show("Error Item is not deleted.");
                }
            }
            else
            {
                MessageBox.Show("Item is not selected");
            }
        }

        
        private void SetControls()
        {
            grvItems.DataSource = bsItems;
            grvItems.AutoGenerateColumns = false;

            var colItemType = grvItems.Columns["colItemType"] as DataGridViewComboBoxColumn;
            colItemType.Items.Add(ItemType.Fuel);
            colItemType.Items.Add(ItemType.Service);
            colItemType.Items.Add(ItemType.Product);

        }

        //button save
            private void btnSave_Click(object sender, EventArgs e)
        {
            ItemListDto item = (ItemListDto)bsItems.Current;

            if (item.Id == 0)
            {
                CreateItem(item);

            }
            else
            {
                UpdateItem(item);
        
            }
        }
        //button delete
        private void btnDelete_Click(object sender, EventArgs e)
        {
            ItemListDto item = (ItemListDto)bsItems.Current;
            DeleteItem(item);
        }
        //method close
        private void btnClose_Click(object sender, EventArgs e)
        {

            LoginF loginF= new LoginF();
            loginF.Show();
            
            this.Close();
        }

        
    }
}
