using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Admin_Login : Form
    {
        string ordb = "Data Source=ORCL; User Id=scott; Password=tiger;";
        OracleConnection conn;

        public Admin_Login()
        {
            InitializeComponent();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = $"select email,Adminpassword from AdminInfo where email='{Username_Textbox.Text.ToString()}' and Adminpassword='{Password_Textbox.Text.ToString()}'";
            cmd.CommandType = CommandType.Text;
            var r = cmd.ExecuteScalar();

            if (r == null)
            {
                Error_label.Text = "Invalid Username or password";
                Error_label.ForeColor = System.Drawing.Color.Red;
            }
            
            else{
                Error_label.Text = "Successful";
                Error_label.ForeColor = System.Drawing.Color.Green;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
    }
}
  