using FuelStation.Model.Enums;
using Microsoft.AspNetCore.Rewrite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FuelStation.Win
{
    public partial class LoginF : Form
    {
        public LoginF()
        {
            InitializeComponent();
        }

        private EmployeeType _type;






        private void btnManager_Click(object sender, EventArgs e)
        {
            _type = EmployeeType.Manager;
            Main main = new Main(_type);
            main.Show();

            this.Hide();
        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            _type = EmployeeType.Cashier;
            Main main = new Main(_type);
            main.Show();

            this.Hide();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            _type = EmployeeType.Staff;
            Main main = new Main(_type);
            main.Show();

            this.Hide();

        }

        private void LoginF_Load(object sender, EventArgs e)
        {

        }
    }
}
