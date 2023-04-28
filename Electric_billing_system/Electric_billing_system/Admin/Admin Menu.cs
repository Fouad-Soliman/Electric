using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electric_billing_system
{
    public partial class Admin_Menu : Form
    {
        public Admin_Menu()
        {
            InitializeComponent();
        }

        private void Mange_pHBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagePH mPH = new ManagePH();
            mPH.ShowDialog();
            this.Show();
        }

        private void Edit_Customer_Pic_Click(object sender, EventArgs e)
        {

        }

        private void ManageBills_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin.Bills.BillsMenu bm =new  Admin.Bills.BillsMenu();
            bm.ShowDialog();
            this.Show();

        }
    }
}
