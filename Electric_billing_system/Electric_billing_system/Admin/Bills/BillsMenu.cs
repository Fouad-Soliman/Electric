using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electric_billing_system.Admin.Bills
{
    public partial class BillsMenu : Form
    {
        public BillsMenu()
        {
            InitializeComponent();
        }

        private void Create_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateBill CB = new CreateBill();
            CB.ShowDialog();
            this.Close();
        }

        private void Approve_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ApproveBills AB = new ApproveBills();
            AB.ShowDialog();
            this.Close();
        }
    }
}
