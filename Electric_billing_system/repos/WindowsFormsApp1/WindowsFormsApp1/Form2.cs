using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        string ordb = "Data source=orcl;User Id=scott;Password=tiger;";
        OracleConnection conn;
        int CustID;

        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select meterid from meter";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                meter_choice.Items.Add(dr[0]);
            }
            dr.Close();
        }

        private void pay_button_Click(object sender, EventArgs e)
        {
            if (creditCard_rdio.Checked)
            {
                credit c = new credit();
                c.ShowDialog();
            }
            else if (Cash_rdio.Checked)
            {
                Cash f = new Cash();

                f.ShowDialog();
            }
        }
    
           


        

        private void meter_choice_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select currentreading , ABS(TotalFees) from meter where meterid=:id";
            cmd.Parameters.Add("id", meter_choice.SelectedItem.ToString());
     

            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                
                current.Text = dr[0].ToString();
                fees.Text = dr[1].ToString();
               
            }
            dr.Close();

        }
    }
}
