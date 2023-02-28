using FuelStation.Model;
using FuelStation.Model.Enums;
using Microsoft.AspNetCore.Rewrite;
using Microsoft.VisualBasic.Logging;
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
    public partial class Main : Form
    {
        private EmployeeType _type;
        public Main(EmployeeType type)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            TypeView();
        }


        private void TypeView()
        {
            switch (_type)
            {
                case EmployeeType.Manager:

                    btnCustomers.Visible = true;
                    btnStaff.Visible = true;
                    btnItems.Visible = true;

                    break;
                case EmployeeType.Cashier:

                    btnCustomers.Visible = true;
                    btnStaff.Visible = true;
                    btnItems.Visible = false;

                    break;
                case EmployeeType.Staff:

                    btnCustomers.Visible = false;
                    btnStaff.Visible = false;
                    btnItems.Visible = true;

                    break;
                default:
                    break;
            }
        }



        private void Main_Load(object sender, EventArgs e)
        {



        }
        private void btnCustomers_Click(object sender, EventArgs e)
        {
            var customersForm = new CustomerF();
            customersForm.ShowDialog();
            this.Close();
        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            var itemFrom = new ItemF();
            itemFrom.ShowDialog();
            this.Close();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            var trasForm = new TransactionF();
            trasForm.ShowDialog();
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            LoginF loginF = new LoginF();
            loginF.Show();
            this.Close();

        }
    }
}
