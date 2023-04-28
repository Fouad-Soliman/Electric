using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
namespace Electric_billing_system
{
    public partial class Customer_Menu : Form
    {
        string ordb = "Data source = orcl; User Id = scott; password = tiger;";
        OracleConnection conn;
        string c_id;
        public Customer_Menu(string cust_id)
        {
            c_id = cust_id;
            InitializeComponent();
        }

        private void Pay_Bills_pic_Click(object sender, EventArgs e)
        {

        }

        private void Print_Invoices_Pic_Click(object sender, EventArgs e)
        {

        }

        private void Print_Invoices_label_Click(object sender, EventArgs e)
        {

        }

        private void Pay_Bills_label_Click(object sender, EventArgs e)
        {

        }

        private void Customer_Menu_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = $"SELECT Firstname,Lastname FROM CUSTOMER WHERE customerid={Convert.ToInt32(c_id)}";
            cmd.CommandType = CommandType.Text;
           
            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();
            Welcome_label.Text+=dr[0].ToString()+" " +dr[1].ToString();
            Account_settings_label.Text = dr[0].ToString() + " " + dr[1].ToString();
        }
    }
}
