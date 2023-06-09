﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SWE_project
{
    public partial class Login_Form : Form
    {
        string ordb = "Data source = orcl; User Id = scott; password = tiger;";
        OracleConnection conn;
        public Login_Form()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            string userEmail = userEmail_textbox.Text;
            string userPassword = userPassword_textbox.Text;
            conn = new OracleConnection(ordb);
            try 
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT CUSTOMERID FROM CUSTOMER WHERE EMAIL = :userEmail AND USERPASSWORD = :userPassword";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(":userEmail", userEmail);
                cmd.Parameters.Add(":userPassword", userPassword);
                OracleDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    if (dr[0].ToString() != null)
                    {
                        MessageBox.Show("Login successful!");
                        // Redirect to the next page
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password!");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username or password!");
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally 
            { 
                conn.Close(); 
            }
            
        }

        private void Register_Link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            registration_form form2 = new registration_form();
            form2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConsumptionPerMonth form = new ConsumptionPerMonth();
            form.Show();
            this.Hide();
        }
    }
}
