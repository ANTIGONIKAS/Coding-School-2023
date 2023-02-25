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
            var response = await client.GetAsync("item");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<ItemListDto>>(content);
            }
            return null;
        }
        //method create
        private async Task CreateItem(ItemListDto item)
        {
            HttpResponseMessage? response = null;

            item.Price = decimal.Parse(colPrice.HeaderText);
            item.Cost = decimal.Parse(colCost.HeaderText);
            item.ItemType = (ItemType)Enum.Parse(typeof(ItemType), colItemType.HeaderText.ToString());


            response = await client.PostAsJsonAsync("item", item);
            SetControls();


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
          this.Close();
        }

        
    }
}
