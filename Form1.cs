using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace David_Gorden_Unit2_IT481
{
    public partial class Form1 : Form
    {
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
    }
}
