using FuelStation.Blazor.Web.Shared;
using FuelStation.Model;
using FuelStation.Model.Enums;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FuelStation.Win
{
    public partial class ItemList : Form
    {
        private readonly HttpClient client = new HttpClient(new HttpClientHandler())
        {
            BaseAddress = new Uri("https://localhost:7216")
        };

        private List<ItemListDto> list = new List<ItemListDto>();
        List<Item> items;
        public ItemList()
        {
            InitializeComponent();
        }

        private void ItemList_Load(object sender, EventArgs e)
        {
            //PopulateItems();
            SetControls();

            
        }
        private void btnLoadItems_Click(object sender, EventArgs e)
        {
            HttpResponseMessage response = client.GetAsync("/item").Result;
            var item = response.Content.ReadAsAsync<IEnumerable<ItemListDto>>().Result;
            bsItems.DataSource = item;
            grvItems.DataSource = bsItems;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Item item = new Item();
            if (txtCode.Text != null && txtDes.Text != null && colItemType != null && txtPrice.Text != null && txtCost.Text != null)
            {
                Item newitem = new Item()
                {
                    Code = txtCode.Text,
                    Description = txtDes.Text,
                    ItemType = (ItemType)Enum.Parse(typeof(ItemType), colItemType.ToString()),
                    Price = Convert.ToDecimal(txtPrice.Text),
                    Cost = Convert.ToDecimal(txtCost.Text)
                };

                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("https://localhost:7216");
                HttpResponseMessage response = client.PostAsJsonAsync("/item", item).Result;
                bsItems.DataSource = newitem;
                grvItems.DataSource = bsItems;
            }

        }


        private void PopulateItems()
        {
            items = new List<Item>();

            Item item1 = new Item()
            {
                Code = "123456",
                Description = "aroma",
                ItemType = Model.Enums.ItemType.Product,
                Price = 10,
                Cost = 5


            };
            items.Add(item1);

            Item item2 = new Item()
            {
                Code = "123457",
                Description = "fuel",
                ItemType = Model.Enums.ItemType.Fuel,
                Price = 20,
                Cost = 10


            };
            items.Add(item2);
            
          // bsItems.DataSource = items;



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
        private void btnOk_Click(object sender, EventArgs e)
        {
            grvItems.EndEdit();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //PopulateItems();
        }

        
    }
}

