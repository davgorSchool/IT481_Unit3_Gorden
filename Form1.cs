using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace David_Gorden_Unit2_IT481
{
    public partial class Form1 : Form
    {
        String successfulUser = "";
        String successfulPassword = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'northwindStoredProcs.CustomerNamesList' table. You can move, or remove it, as needed.
            this.customerNamesListTableAdapter.Fill(this.northwindStoredProcs.CustomerNamesList);
            // TODO: This line of code loads data into the 'northwindStoredProcs.CustomerCount' table. You can move, or remove it, as needed.
            this.customerCountTableAdapter.Fill(this.northwindStoredProcs.CustomerCount);

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            resetScreen(); //unload tables if connection were to fail
            try
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;" +
                    "Initial Catalog=Northwind;" +
                    "User ID=" + txbx_username.Text + ";" +
                    "Password=" + txbx_password.Text + ";" +
                    "Connect Timeout=30;" +
                    "Encrypt=False;" +
                    "TrustServerCertificate=False;" +
                    "ApplicationIntent=ReadWrite;" +
                    "MultiSubnetFailover=False";
                conn.Open();
                lbl_message.Text = "Logged in as: " + txbx_username.Text; //display error message
                successfulUser = txbx_username.Text;
                successfulPassword = txbx_password.Text;
                btn_customers.Visible = true;
                btn_employees.Visible = true;
                btn_orders.Visible = true;
            }
            catch (System.Data.SqlClient.SqlException errormsg)
            {
                lbl_error.Text = "Invalid log in"; //display error message
                return;
            }
        }
        public void resetMessages()
        {
            lbl_error.Text = ""; //reset error message
            lbl_message.Text = ""; //reset messages
        }
        public void resetScreen()
        {
            successfulUser = "";
            successfulPassword = "";
            btn_customers.Visible = false;
            btn_employees.Visible = false;
            btn_orders.Visible = false;
            datagrid.DataSource = null;
            resetMessages();
        }

        private void button1_Click(object sender, EventArgs e)//view employees
        {
            updateDatatable("SELECT * FROM dbo.Employees");
        }
        public void updateDatatable(String selectStatement)
        {
            datagrid.DataSource = null;
            try
            {
                resetMessages();
                var connectionStringVal = "Data Source=(localdb)\\MSSQLLocalDB;" +
                        "Initial Catalog=Northwind;" +
                        "User ID=" + successfulUser + ";" +
                        "Password=" + successfulPassword + ";" +
                        "Connect Timeout=30;" +
                        "Encrypt=False;" +
                        "TrustServerCertificate=False;" +
                        "ApplicationIntent=ReadWrite;" +
                        "MultiSubnetFailover=False";
                var c = new SqlConnection(connectionStringVal); // Your Connection String here
                var dataAdapter = new SqlDataAdapter(selectStatement, c);
                var ds = new DataSet();
                dataAdapter.Fill(ds);
                datagrid.ReadOnly = true;
                datagrid.DataSource = ds.Tables[0];
            }
            catch (System.Data.SqlClient.SqlException errormsg)
            {
                lbl_error.Text = "Permission DENIED"; //display error message
            }
        }

        private void btn_customers_Click(object sender, EventArgs e)
        {
            updateDatatable("SELECT * FROM dbo.Customers");
        }

        private void btn_orders_Click(object sender, EventArgs e)
        {
            updateDatatable("SELECT * FROM dbo.Orders");
        }
    }
}
