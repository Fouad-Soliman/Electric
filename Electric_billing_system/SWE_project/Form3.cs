using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWE_project
{
    public partial class ConsumptionPerMonth : Form
    {
        string ordb = "Data source = orcl; User Id = scott; password = tiger; ";
        OracleConnection conn;

        public ConsumptionPerMonth()
        {
            InitializeComponent();
        }

        private void ConsumptionPerMonth_Load(object sender, EventArgs e)
        {

        }

        private void ShowConsumption_Button_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select currentreading, previousreading from METER where METERID = :METERID";
            cmd.Parameters.Add("MeterID", MeterID_textBox.Text);
            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ConsumptionPerMonth_TextBox.Text = reader[0].ToString();
                PreviousConsumption_textbox.Text = reader[1].ToString();
                
            }
        }
    }
}
