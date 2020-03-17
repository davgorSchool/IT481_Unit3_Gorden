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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.northwindStoredProcs = new David_Gorden_Unit2_IT481.NorthwindStoredProcs();
            this.customerCountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerCountTableAdapter = new David_Gorden_Unit2_IT481.NorthwindStoredProcsTableAdapters.CustomerCountTableAdapter();
            this.customerTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.customerNamesListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerNamesListTableAdapter = new David_Gorden_Unit2_IT481.NorthwindStoredProcsTableAdapters.CustomerNamesListTableAdapter();
            this.contactNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindStoredProcs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerCountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerNamesListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Names";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(446, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Count";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerTotalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.customerCountBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(417, 222);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // northwindStoredProcs
            // 
            this.northwindStoredProcs.DataSetName = "NorthwindStoredProcs";
            this.northwindStoredProcs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerCountBindingSource
            // 
            this.customerCountBindingSource.DataMember = "CustomerCount";
            this.customerCountBindingSource.DataSource = this.northwindStoredProcs;
            // 
            // customerCountTableAdapter
            // 
            this.customerCountTableAdapter.ClearBeforeFill = true;
            // 
            // customerTotalDataGridViewTextBoxColumn
            // 
            this.customerTotalDataGridViewTextBoxColumn.DataPropertyName = "CustomerTotal";
            this.customerTotalDataGridViewTextBoxColumn.HeaderText = "CustomerTotal";
            this.customerTotalDataGridViewTextBoxColumn.Name = "customerTotalDataGridViewTextBoxColumn";
            this.customerTotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.contactNameDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.customerNamesListBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 41);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(169, 397);
            this.dataGridView2.TabIndex = 3;
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
            // contactNameDataGridViewTextBoxColumn
            // 
            this.contactNameDataGridViewTextBoxColumn.DataPropertyName = "ContactName";
            this.contactNameDataGridViewTextBoxColumn.HeaderText = "ContactName";
            this.contactNameDataGridViewTextBoxColumn.Name = "contactNameDataGridViewTextBoxColumn";
            this.contactNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindStoredProcs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerCountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerNamesListBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private NorthwindStoredProcs northwindStoredProcs;
        private System.Windows.Forms.BindingSource customerCountBindingSource;
        private NorthwindStoredProcsTableAdapters.CustomerCountTableAdapter customerCountTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource customerNamesListBindingSource;
        private NorthwindStoredProcsTableAdapters.CustomerNamesListTableAdapter customerNamesListTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNameDataGridViewTextBoxColumn;
    }
}

