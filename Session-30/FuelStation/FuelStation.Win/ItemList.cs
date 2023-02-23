using FuelStation.Model;
using FuelStation.Model.Enums;
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
    public partial class ItemList : Form
    {
         List<Item> items;
        public ItemList()
        {
            InitializeComponent();
        }

        private void ItemList_Load(object sender, EventArgs e)
        {
            PopulateItems();
            SetControls();

            
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
            PopulateItems();
        }
    }
}

