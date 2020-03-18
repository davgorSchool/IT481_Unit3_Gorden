namespace David_Gorden_Unit2_IT481
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.customerCountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.northwindStoredProcs = new David_Gorden_Unit2_IT481.NorthwindStoredProcs();
            this.customerCountTableAdapter = new David_Gorden_Unit2_IT481.NorthwindStoredProcsTableAdapters.CustomerCountTableAdapter();
            this.customerNamesListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerNamesListTableAdapter = new David_Gorden_Unit2_IT481.NorthwindStoredProcsTableAdapters.CustomerNamesListTableAdapter();
            this.pg_login = new System.Windows.Forms.Panel();
            this.btn_login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbx_username = new System.Windows.Forms.TextBox();
            this.txbx_password = new System.Windows.Forms.TextBox();
            this.pg_tables = new System.Windows.Forms.Panel();
            this.lbl_error = new System.Windows.Forms.Label();
            this.lbl_message = new System.Windows.Forms.Label();
            this.dataSet1 = new System.Data.DataSet();
            this.dataSet2 = new System.Data.DataSet();
            this.datagrid = new System.Windows.Forms.DataGridView();
            this.btn_employees = new System.Windows.Forms.Button();
            this.btn_orders = new System.Windows.Forms.Button();
            this.btn_customers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.customerCountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindStoredProcs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerNamesListBindingSource)).BeginInit();
            this.pg_login.SuspendLayout();
            this.pg_tables.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // customerCountBindingSource
            // 
            this.customerCountBindingSource.DataMember = "CustomerCount";
            this.customerCountBindingSource.DataSource = this.northwindStoredProcs;
            // 
            // northwindStoredProcs
            // 
            this.northwindStoredProcs.DataSetName = "NorthwindStoredProcs";
            this.northwindStoredProcs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerCountTableAdapter
            // 
            this.customerCountTableAdapter.ClearBeforeFill = true;
            // 
            // customerNamesListBindingSource
            // 
            this.customerNamesListBindingSource.DataMember = "CustomerNamesList";
            this.customerNamesListBindingSource.DataSource = this.northwindStoredProcs;
            // 
            // customerNamesListTableAdapter
            // 
            this.customerNamesListTableAdapter.ClearBeforeFill = true;
            // 
            // pg_login
            // 
            this.pg_login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pg_login.Controls.Add(this.txbx_password);
            this.pg_login.Controls.Add(this.txbx_username);
            this.pg_login.Controls.Add(this.label2);
            this.pg_login.Controls.Add(this.label1);
            this.pg_login.Controls.Add(this.btn_login);
            this.pg_login.Location = new System.Drawing.Point(12, 12);
            this.pg_login.Name = "pg_login";
            this.pg_login.Size = new System.Drawing.Size(200, 184);
            this.pg_login.TabIndex = 0;
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(58, 137);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 23);
            this.btn_login.TabIndex = 0;
            this.btn_login.Text = "Log in";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // txbx_username
            // 
            this.txbx_username.Location = new System.Drawing.Point(68, 35);
            this.txbx_username.Name = "txbx_username";
            this.txbx_username.Size = new System.Drawing.Size(100, 20);
            this.txbx_username.TabIndex = 3;
            // 
            // txbx_password
            // 
            this.txbx_password.Location = new System.Drawing.Point(68, 81);
            this.txbx_password.Name = "txbx_password";
            this.txbx_password.Size = new System.Drawing.Size(100, 20);
            this.txbx_password.TabIndex = 4;
            // 
            // pg_tables
            // 
            this.pg_tables.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pg_tables.Controls.Add(this.datagrid);
            this.pg_tables.Location = new System.Drawing.Point(219, 13);
            this.pg_tables.Name = "pg_tables";
            this.pg_tables.Size = new System.Drawing.Size(569, 425);
            this.pg_tables.TabIndex = 1;
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_error.Location = new System.Drawing.Point(13, 203);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(0, 20);
            this.lbl_error.TabIndex = 2;
            // 
            // lbl_message
            // 
            this.lbl_message.AutoSize = true;
            this.lbl_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_message.Location = new System.Drawing.Point(12, 203);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(0, 20);
            this.lbl_message.TabIndex = 3;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "NewDataSet";
            // 
            // datagrid
            // 
            this.datagrid.AllowUserToAddRows = false;
            this.datagrid.AllowUserToDeleteRows = false;
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid.Location = new System.Drawing.Point(3, 34);
            this.datagrid.Name = "datagrid";
            this.datagrid.ReadOnly = true;
            this.datagrid.Size = new System.Drawing.Size(561, 386);
            this.datagrid.TabIndex = 0;
            // 
            // btn_employees
            // 
            this.btn_employees.Location = new System.Drawing.Point(115, 288);
            this.btn_employees.Name = "btn_employees";
            this.btn_employees.Size = new System.Drawing.Size(102, 23);
            this.btn_employees.TabIndex = 1;
            this.btn_employees.Text = "View Employees";
            this.btn_employees.UseVisualStyleBackColor = true;
            this.btn_employees.Visible = false;
            this.btn_employees.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_orders
            // 
            this.btn_orders.Location = new System.Drawing.Point(115, 346);
            this.btn_orders.Name = "btn_orders";
            this.btn_orders.Size = new System.Drawing.Size(102, 23);
            this.btn_orders.TabIndex = 2;
            this.btn_orders.Text = "View Orders";
            this.btn_orders.UseVisualStyleBackColor = true;
            this.btn_orders.Visible = false;
            this.btn_orders.Click += new System.EventHandler(this.btn_orders_Click);
            // 
            // btn_customers
            // 
            this.btn_customers.Location = new System.Drawing.Point(115, 317);
            this.btn_customers.Name = "btn_customers";
            this.btn_customers.Size = new System.Drawing.Size(102, 23);
            this.btn_customers.TabIndex = 3;
            this.btn_customers.Text = "View customers";
            this.btn_customers.UseVisualStyleBackColor = true;
            this.btn_customers.Visible = false;
            this.btn_customers.Click += new System.EventHandler(this.btn_customers_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_customers);
            this.Controls.Add(this.lbl_message);
            this.Controls.Add(this.btn_orders);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.btn_employees);
            this.Controls.Add(this.pg_tables);
            this.Controls.Add(this.pg_login);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerCountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindStoredProcs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerNamesListBindingSource)).EndInit();
            this.pg_login.ResumeLayout(false);
            this.pg_login.PerformLayout();
            this.pg_tables.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private NorthwindStoredProcs northwindStoredProcs;
        private System.Windows.Forms.BindingSource customerCountBindingSource;
        private NorthwindStoredProcsTableAdapters.CustomerCountTableAdapter customerCountTableAdapter;
        private System.Windows.Forms.BindingSource customerNamesListBindingSource;
        private NorthwindStoredProcsTableAdapters.CustomerNamesListTableAdapter customerNamesListTableAdapter;
        private System.Windows.Forms.Panel pg_login;
        private System.Windows.Forms.TextBox txbx_password;
        private System.Windows.Forms.TextBox txbx_username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Panel pg_tables;
        private System.Windows.Forms.Label lbl_error;
        private System.Windows.Forms.Label lbl_message;
        private System.Windows.Forms.Button btn_customers;
        private System.Windows.Forms.Button btn_orders;
        private System.Windows.Forms.Button btn_employees;
        private System.Windows.Forms.DataGridView datagrid;
        private System.Data.DataSet dataSet1;
        private System.Data.DataSet dataSet2;
    }
}

